using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiServerQueueingSystem
{
    public partial class MultiServerQueueingSystem : Form
    {
        public MultiServerQueueingSystem()
        {
            InitializeComponent();
        }


        private void button_Evaluate_Click(object sender, EventArgs e)
        {
            if (textBox_MIT.Text == "" || textBox_MST1.Text == "" || textBox_MST2.Text == "" || textBox_NOC.Text == "")
            {
                return;
            }

            Server s = new Server();

            s.mean_interarrival = Convert.ToDouble(textBox_MIT.Text);
            s.mean_service[1] = Convert.ToDouble(textBox_MST1.Text);
            s.mean_service[2] = Convert.ToDouble(textBox_MST2.Text);
            s.num_delays_required = Convert.ToInt32(textBox_NOC.Text);

            s.initialize();

            Random ran = new Random();

            while (s.num_custs_delayed[1] < s.num_delays_required)
            {
                s.timing();    

                switch (s.next_event_type)
                {
                    case 1:
                        s.arrive(s.sim_time, 1);
                        s.update_time_avg_stats(1);
                        break;
                    case 2:
                        s.depart(1);
                        s.update_time_avg_stats(1);

                        if (ran.NextDouble() > .3)
                        {
                            s.arrive(s.sim_time, 2);
                            s.update_time_avg_stats(2);
                        }
                        break;
                    case 3:
                        s.depart(2);
                        s.update_time_avg_stats(2);
                        break;
                }
            }

            while (s.num_in_q[2]> 0)
            {
                s.timing();
                s.depart(2);
                s.update_time_avg_stats(2);
            }

            label_SimulationFirstServer.Text = s.report(1);
            label_SimulationSecondServer.Text = s.report(2);

        }
        private void button_Clear_Click(object sender, EventArgs e)
        {
            textBox_MIT.ResetText();
            textBox_MST1.ResetText();
            textBox_MST2.ResetText();
            textBox_NOC.ResetText();
            label_SimulationFirstServer.ResetText();
            label_SimulationSecondServer.ResetText();
        }
        class Server
        {
            const int Q_LIMIT = 100;
            const int BUSY = 1;
            const int IDLE = 0;

            public int next_event_type;
            public int[] num_custs_delayed = new int[3];
            public int num_delays_required;
            int num_events = 3;
            public int[] num_in_q = new int[3];
            int[] server_status = new int[3];

            double[] area_num_in_q = new double[3];
            double[] area_server_status = new double[3];
            public double mean_interarrival;
            public double[] mean_service = new double[3];
            public double sim_time;
            double[,] time_arrival = new double[3 , Q_LIMIT + 1];
            double[] time_last_event = new double[3];
            double[] time_next_event = new double[4];
            double[] total_of_delays = new double[3];

            string result;
        
            Random random = new Random();
            public void initialize()
            {
                sim_time = 0.0;

                server_status[1] = IDLE;
                server_status[2] = IDLE;

                num_in_q[1] = 0;
                num_in_q[2] = 0;

                time_last_event[1] = 0.0;
                time_last_event[2] = 0.0;

                num_custs_delayed[1] = 0;
                num_custs_delayed[2] = 0;

                total_of_delays[1] = 0.0;
                total_of_delays[2] = 0.0;

                area_num_in_q[1] = 0.0;
                area_num_in_q[2] = 0.0;

                area_server_status[1] = 0.0;
                area_server_status[2] = 0.0;

                time_next_event[1] = sim_time + expon(mean_interarrival);
                time_next_event[2] = Math.Pow(10, +30);
                time_next_event[3] = Math.Pow(10, +30); 

            }

            public void timing()
            {
                double min_time_next_event = Math.Pow(10, +29);
                next_event_type = 0;

                for (int i = 1; i <= num_events; ++i)
                {
                    if (time_next_event[i] < min_time_next_event)
                    {
                        min_time_next_event = time_next_event[i];
                        next_event_type = i;
                    }
                }

                if (next_event_type == 0)
                {
                    MessageBox.Show("Event list empty at time " + sim_time);
                    Application.Exit();
                }
                sim_time = min_time_next_event;
            }

            public void arrive(double newTime, int ServerName)
            {
                double delay;
                if (ServerName == 1)
                {
                    time_next_event[1] = sim_time + expon(mean_interarrival);
                }

                if (server_status[ServerName] == BUSY)
                {
                    ++num_in_q[ServerName];

                    if (num_in_q[ServerName] > Q_LIMIT)
                    {
                        MessageBox.Show("Over flow of the queue time arrival at time " + sim_time);
                        Application.Exit();
                    }

                    time_arrival[ServerName, num_in_q[ServerName]] = newTime;
                }

                else
                {
                    delay = 0.0;
                    total_of_delays[ServerName] += delay;

                    ++num_custs_delayed[ServerName];
                    server_status[ServerName] = BUSY;

                    time_next_event[ServerName + 1] = sim_time + expon(mean_service[ServerName]);

                }
            }

            public void depart(int ServerName)
            {
                double delay;

                if (num_in_q[ServerName] == 0)
                {
                    server_status[ServerName] = IDLE;
                    time_next_event[ServerName + 1] = Math.Pow(10, +30);
                }
                else
                {
                    --num_in_q[ServerName];

                    delay = sim_time - time_arrival[ServerName, 1];
                    total_of_delays[ServerName] += delay;

                    ++num_custs_delayed[ServerName];

                    time_next_event[ServerName + 1] = sim_time + expon(mean_service[ServerName]);

                    for (int i = 1; i <= num_in_q[ServerName]; ++i)
                    {
                        if (i == Q_LIMIT) break;
                        time_arrival[ServerName, i] = time_arrival[ServerName, (i + 1)];
                    }
                }
            }

            public string report(int ServerName)
            {
                result = "Average delay in queue " + Math.Round((total_of_delays[ServerName] / num_custs_delayed[ServerName]), 5) + " minutes\n\n"
                                + "Average number in queue " + Math.Round((area_num_in_q[ServerName] / sim_time), 5) + "\n\n"
                                + "Server utilization " + Math.Round((area_server_status[ServerName] / sim_time), 5) + "\n\n"
                                + "Time simulation ended " + Math.Round(sim_time, 5) + " minutes\n\n"
                                + "Total customer who got service " + num_custs_delayed[ServerName] + "\n\n";

                return result;
            }

            public void update_time_avg_stats(int ServerName)
            {
                double time_since_last_event;

                time_since_last_event = sim_time - time_last_event[ServerName];
                time_last_event[ServerName] = sim_time;

                area_num_in_q[ServerName] += num_in_q[ServerName] * time_since_last_event;

                area_server_status[ServerName] += server_status[ServerName] * time_since_last_event;
            }
            public double expon(double mean)
            {
                return (-mean * Math.Log(random.NextDouble()));
            }

        }
    }
}