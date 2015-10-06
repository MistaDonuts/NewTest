using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace os_sim
{
    class Process
    {
        private int id;                 //ID
        public int start_cycle;      //Tiempo de llegada
        public int total_cycles;       //Ciclos totales
        public int current_cycles;     //Tiempo en el sistema
        public int total_cpu;          //Uso de CPU
        public int current_cpu;        //Tiempo acum. de uso de CPU
        public int total_io;          //Tiempo de uso de I/O
        public int current_io;        //Tiempo
        public int io_start;        //Hora de uso de I/O
        public int finish_time;    //Tiempo finalizacion

        public int quantum;
        public Process(int next_id, int cycle, int avrg, Random rand, int q)
        {
            id = next_id;
            start_cycle = cycle;

            total_cycles = rand.Next(Convert.ToInt32(avrg*0.75), Convert.ToInt32(avrg*1.25));
            total_io = rand.Next(0, total_cycles);
            total_cpu = total_cycles - total_io;

            current_cycles = 0;
            current_cpu = 0;
            current_io = 0;

            quantum = q;
        }
        public string getData()
        {
            string data = String.Format("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t{7}",
                getID(),start_cycle,total_cycles,current_cycles,total_cpu,current_cpu,total_io,current_io);
            return data;
        }
        public string getID()
        { return "P" + (id < 10 ? "0" : "") + id; }
    }
}