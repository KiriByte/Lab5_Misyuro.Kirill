using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Misyuro.Kirill
{
    class Computer
    {
        string model;
        int price;
        RAM ram = new RAM();
        HDD hdd = new HDD();
        public Computer()
        {
            model = "UNKNOWN";
            price = 0;
        }

        public Computer(string model, int price,
            string nameRAM, int memoryRAM,
            string nameHDD, int capacityHDD, int typeHDD)
        {
            this.model = model;
            this.price = price;
            ram = new RAM(nameRAM, memoryRAM);
            hdd = new HDD(nameHDD, capacityHDD, typeHDD);

        }
        public string Info()
        {
            StringBuilder str = new StringBuilder();
            str.Append($"Model: {model}\n");
            str.Append($"Price: {price}\n");
            str.Append(ram.Info());
            str.Append(hdd.Info());
            return str.ToString();
        }


        class RAM
        {
            internal string name;
            internal int memory;
            public RAM()
            {
                name = "UNKNOWN";
                memory = 0;
            }
            public RAM(string name, int memory)
            {
                this.name = name;
                this.memory = memory;
            }



            public string Info()
            {
                StringBuilder str = new StringBuilder();
                str.AppendLine("RAM:");
                str.AppendLine($"\tName: {name}");
                str.AppendLine($"\tCapacity: {memory} GB");
                return str.ToString();
            }
        }
        class HDD
        {
            internal string name;
            internal int capacity;
            public TypeHDD typeHDD;
            public enum TypeHDD
            {
                Internal,
                External,
                UNKNOWN
            };
            public HDD()
            {
                name = "UNKNOWN";
                capacity = 0;
                typeHDD = TypeHDD.UNKNOWN;
            }
            public HDD(string name, int capacity, int typeHDD)
            {
                this.name = name;
                this.capacity = capacity;
                this.typeHDD = (TypeHDD)typeHDD;
            }

            public string Info()
            {
                StringBuilder str = new StringBuilder();
                str.AppendLine("HDD:");
                str.AppendLine($"\tName: {name}");
                str.AppendLine($"\tCapacity: {capacity} GB");
                str.AppendLine($"\tType: {typeHDD}");
                return str.ToString();
            }

        }

    }

}
