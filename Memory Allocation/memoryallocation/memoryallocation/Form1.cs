using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace memoryallocation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Byte.Checked = true;
            Byte1.Checked = true;
            Byte2.Checked = true;
            FirstFit.Checked = true;
        }
        static int DisplayALL = 0;
        private void display(string s, int error)
        {
            StatusBox.ResetText();
            if (error == 0) StatusBox.ForeColor = Color.Green;
            else StatusBox.ForeColor = Color.Red;
            StatusBox.Text = s;
        }
        private void AddRow(decimal A, decimal S, int i)
        {
            double f;
            string D;
            if (i == -1)
            {
                D = "Hole";
            }
            else
            {
                D = "P"+i.ToString();
            }
            if (S >= 1073741824)
            {
                f = (int)(S / 1073741824);
                f += (double)((double)(S % 1073741824) / 1073741824.0);
                T.Rows.Add(A, f.ToString() + "  GB", D);
            }
            else if (S >= 1048576)
            {
                f = (int)(S / 1048576);
                f += (double)((double)(S % 1048576) / 1048576.0);
                T.Rows.Add(A, f.ToString() + "  MB", D);
            }
            else if(S>=1024)
            {
                f = (int)(S / 1024);
                f += (double)((double)(S % 1024)/1024.0);
                T.Rows.Add(A, f.ToString() + "  KB", D);
            }
            else
            {
                
                T.Rows.Add(A, S.ToString() + "  Byte", D);
            }
            if (DisplayALL == 0) RAM.DataSource = T;

        }
        private void tableinit()
        {
            T.Rows.Clear();
            T.Columns.Clear();
            T.Columns.Add("Starting Address", typeof(string));
            T.Columns.Add("Size", typeof(string));
            T.Columns.Add("PID", typeof(string));
        }
        private void displayAll()
        {
            T.Rows.Clear();
            T.Columns.Clear();
            tableinit();
            DisplayALL = 1;
            Global.sizeofhole = 0;
            for (int i = 0; i < Global.intervals.Count; i++)
            {
                AddRow(Global.intervals[i].begin, Global.intervals[i].size, Global.intervals[i].id);
                if (Global.intervals[i].id == -1) 
                {
                    Global.sizeofhole += Global.intervals[i].size;
                }
            }
            textBox2.Text = Global.sizeofhole.ToString() + "  byte";
            DisplayALL = 0;
            RAM.DataSource = T;
            
        }
        private void INSERT(int index, decimal S) 
        {
            if (index == -1)
            {
                /*new*/
                if ((S > Global.sizeofhole)||(fragmentation.Checked == false))
                {
                    display("There is no enough size to allocate this process", 1);
                    return;
                }
                else 
                {
                    List<interval> temp = new List<interval>(50);
                    for (int i = 0; i < Global.intervals.Count; i++) 
                    {
                        if (Global.intervals[i].id == -1)  continue;
                        if (temp.Count == 0) 
                        {
                            temp.Add(new interval(0, Global.intervals[i].size - 1, Global.intervals[i].size, Global.intervals[i].id));
                        }
                        else 
                        {
                            temp.Add(new interval(temp[temp.Count-1].end+1, temp[temp.Count-1].end+Global.intervals[i].size, Global.intervals[i].size, Global.intervals[i].id));
                        }
                    }
                   
                    ProcessId++;
                    Global.sizeofhole -= S;
                    temp.Add(new interval(temp[temp.Count - 1].end + 1, temp[temp.Count - 1].end + S, S, ProcessId));
                    if (Global.sizeofhole != 0) 
                    {
                        temp.Add(new interval(temp[temp.Count - 1].end + 1, temp[temp.Count - 1].end + Global.sizeofhole, Global.sizeofhole,-1));
                    }
                    Global.intervals.Clear();
                    for (int i = 0; i < temp.Count; i++) 
                    {
                        Global.intervals.Add(temp[i]);
                    }
                    displayAll();
                    display("The process p" + (ProcessId).ToString() + " is allocated successfully", 0);

                }
            }
            else if (Global.intervals[index].size == S)
            {
               
                ProcessId++;
                Global.intervals[index].id = ProcessId;
                displayAll();
            }
            else
            {
                
                ProcessId++;
                if (index == (Global.intervals.Count - 1))
                {
                    decimal oldsize = Global.intervals[index].size;
                    decimal oldend = Global.intervals[index].end;
                    Global.intervals[index].id = ProcessId;
                    Global.intervals[index].size = S;
                    Global.intervals[index].end = Global.intervals[index].begin + S - 1;
                    Global.intervals.Add(new interval(Global.intervals[index].end + 1, oldend, oldend - (Global.intervals[index].end + 1) + 1, -1));

                }
                else
                {
                    
                    decimal oldsize = Global.intervals[index].size;
                    decimal oldend = Global.intervals[index].end;
                    Global.intervals[index].id = ProcessId;
                    Global.intervals[index].size = S;
                    Global.intervals[index].end = Global.intervals[index].begin + S - 1;
                    Global.intervals.Insert(index + 1, new interval(Global.intervals[index].end + 1, oldend, oldend - (Global.intervals[index].end + 1) + 1, -1));
                }
               
                displayAll();
                
            }
        }
        private void FirstFitAllocatation(decimal S)
        {
            int index;
            index = Global.intervals.FindIndex(p => ((p.size >= S) && (p.id == -1)));
            if(index!=-1)display("The process p" + (ProcessId+1).ToString() + " is allocated successfully", 0);
            INSERT(index, S);

        }
        private void BestFitAllocatation(decimal S) 
        {
            int index = -1;
            for (int i = 0; i < Global.intervals.Count; i++) 
            {
                if ( (Global.intervals[i].size >= S) &&(Global.intervals[i].id==-1)) 
                {
                    if ((index == -1)) index = i;
                    else 
                    {
                        if (Global.intervals[i].size < Global.intervals[index].size) index = i;
                    }
                }  
            }
            if (index != -1) display("The process p" + (ProcessId+1).ToString() + " is allocated successfully", 0);
            
            INSERT(index, S);

        }
        private void deallocatation(int i) 
        {

            int index;
            index = Global.intervals.FindIndex(p => p.id==i );
           
            Global.intervals[index].id = -1;
            if (Global.intervals.Count!=1) 
            {
                if (index == (Global.intervals.Count - 1)) 
                {
                    if (Global.intervals[index - 1].id == -1) 
                    {
                        Global.intervals[index - 1].end = Global.intervals[index].end;
                        Global.intervals[index - 1].size += Global.intervals[index].size;
                        Global.intervals.RemoveAt(index);
                    }
                }
                else if (index == 0) 
                {
                    if (Global.intervals[index + 1].id == -1)
                    {
                        Global.intervals[index].end = Global.intervals[index+1].end;
                        Global.intervals[index].size += Global.intervals[index+1].size;
                        Global.intervals.RemoveAt(index+1);
                    }
                }
                else 
                {
                    
                    if (Global.intervals[index + 1].id == -1)
                    {
                        Global.intervals[index].end = Global.intervals[index + 1].end;
                        Global.intervals[index].size += Global.intervals[index + 1].size;
                        Global.intervals.RemoveAt(index + 1);
                    }
                    if (Global.intervals[index - 1].id == -1)
                    {
                        Global.intervals[index - 1].end = Global.intervals[index].end;
                        Global.intervals[index - 1].size += Global.intervals[index].size;
                        Global.intervals.RemoveAt(index);
                    }
                    
                }
            }

            displayAll();
            display("P" + i.ToString() + " is deallocated successfully", 0);
        }
        
        
        private void Set_Click(object sender, EventArgs e)
        {
            if (GigaByte.Checked == true)
            {
                display("Memory size is set successfully", 0);
                MemorySize.Enabled = false;
                Holes.Enabled = true;
                Global.MemorySize = MSize.Value * 1024 * 1024 * 1024;
            }
            else if (MegaByte.Checked == true)
            {
                display("Memory size is set successfully", 0);
                MemorySize.Enabled = false;
                Holes.Enabled = true;
                Global.MemorySize = MSize.Value * 1024 * 1024;
            }
            else if (KiloByte.Checked == true)
            {
                display("Memory size is set successfully", 0);
                MemorySize.Enabled = false;
                Holes.Enabled = true;
                Global.MemorySize = MSize.Value * 1024;
            }
            else if (Byte.Checked == true)
            {
                display("Memory size is set successfully", 0);
                MemorySize.Enabled = false;
                Holes.Enabled = true;
                Global.MemorySize = MSize.Value;
            }
            else
            {
                display("Error: you have to selsect size type", 1);
            }
        }
        static List<interval> holes = new List<interval>(50);
        static int HoleID = 0;
        static int ProcessId = 0;
        static DataTable T = new DataTable();
        private void AddHole_Click(object sender, EventArgs e)
        {
            if (GigaByte1.Checked == true)
            {
                
                decimal begin, end, size;
                begin = holeAddress.Value;
                size = HSize.Value * 1024 * 1024 * 1024;
                end = begin + size - 1;
                if (end >= Global.MemorySize)
                {
                    display("Error: you want to set a hole Out of memory size", 1);
                }
                else
                {
                    HoleID++;
                    Global.sizeofhole += size;/*new*/
                    holes.Add(new interval(begin, end, size, HoleID));
                    display("The hole is added successfully", 0);
                }
            }
            else if (MegaByte1.Checked == true)
            {
               
                decimal begin, end, size;
                begin = holeAddress.Value;
                size = HSize.Value * 1024 * 1024;
                end = begin + size - 1;
                if (end >= Global.MemorySize)
                {
                    display("Error: you want to set a hole Out of memory size", 1);
                }
                else
                {
                    HoleID++;
                    Global.sizeofhole += size;/*new*/
                    holes.Add(new interval(begin, end, size, HoleID));
                    display("The hole is added successfully", 0);
                }
            }
            else if (KiloByte1.Checked == true)
            {

                
                decimal begin, end, size;
                begin = holeAddress.Value;
                size = HSize.Value * 1024;
                end = begin + size - 1;
                if (end >= Global.MemorySize)
                {
                    display("Error: you want to set a hole Out of memory size", 1);
                }
                else
                {
                    HoleID++;
                    Global.sizeofhole += size;/*new*/
                    holes.Add(new interval(begin, end, size, HoleID));
                    display("The hole is added successfully", 0);
                }
            }
            else if (Byte1.Checked == true)
            {


                decimal begin, end, size;
                begin = holeAddress.Value;
                size = HSize.Value;
                end = begin + size - 1;
                if (end >= Global.MemorySize)
                {
                    display("Error: you want to set a hole Out of memory size", 1);
                }
                else
                {
                    HoleID++;
                    Global.sizeofhole += size;/*new*/
                    holes.Add(new interval(begin, end, size, HoleID));
                    display("The hole is added successfully", 0);
                }
            }
            else
            {
                display("Error: you have to select size type of hole", 1);
            }
        }

        private void Done_Click(object sender, EventArgs e)
        {
            Holes.Enabled = false;
            display("the holes is added successfully", 0);
            if (HoleID == 0)
            {
                ProcessId++;
                Global.intervals.Add(new interval(0, Global.MemorySize - 1, Global.MemorySize, ProcessId));
                tableinit();
                AddRow(0, Global.MemorySize, ProcessId);
            }
            else
            {
                holes.Sort();
                interval[] x = holes.ToArray();
                interval min = x[0];
                holes.Clear();
                for (int i = 1; i < HoleID; i++)
                {
                    if (min.end >= x[i].begin)
                    {
                        min.end = Math.Max(min.end, x[i].end);
                        min.size = min.end - min.begin + 1;
                    }
                    else
                    {
                        holes.Add(min);
                        min = x[i];

                    }
                }
                holes.Add(min);
                decimal B, E, S;
                for (int i = 0; i < holes.Count; i++)
                {
                    B = holes[i].begin;
                    E = holes[i].end;
                    S = holes[i].size;
                    if (B == 0)
                    {
                        Global.intervals.Add(new interval(B, E, S, -1));
                    }
                    else if (i == 0)
                    {
                        ProcessId++;
                        Global.intervals.Add(new interval(0, B - 1, B, ProcessId));
                        Global.intervals.Add(new interval(B, E, S, -1));
                    }
                    else
                    {
                        ProcessId++;
                        Global.intervals.Add(new interval(holes[i - 1].end + 1, B - 1, (B - 1) - (holes[i - 1].end + 1) + 1, ProcessId));
                        Global.intervals.Add(new interval(B, E, S, -1));
                    }
                }
                if (Global.intervals[Global.intervals.Count - 1].end < (Global.MemorySize - 1))
                {
                    ProcessId++;
                    Global.intervals.Add(new interval(Global.intervals[Global.intervals.Count - 1].end + 1, Global.MemorySize - 1, (Global.MemorySize - 1) - (Global.intervals[Global.intervals.Count - 1].end + 1) + 1, ProcessId));
                }
                holes.Clear();
                HoleID = 0;
                displayAll();
            }
            Result.Visible = true;
            PID.Text = "P" + (ProcessId + 1).ToString();
            AllocateProcess.Enabled = true;


        }

        private void Allocate_Click(object sender, EventArgs e)
        {
            Allocate.Enabled=false;
            if (GigaByte2.Checked == true)
            {
                if (FirstFit.Checked == true) 
                {
                    FirstFitAllocatation(PSize.Value*1024*1024*1024);
                }
                else 
                {
                    BestFitAllocatation(PSize.Value*1024*1024*1024);
                }
                
            }
            else if (MegaByte2.Checked == true)
            {
                if (FirstFit.Checked == true)
                {
                    FirstFitAllocatation(PSize.Value * 1024 * 1024 );
                }
                else
                {
                    BestFitAllocatation(PSize.Value * 1024 * 1024);
                }
            }
            else if (KiloByte2.Checked == true)
            {
                if (FirstFit.Checked == true)
                {
                    FirstFitAllocatation(PSize.Value * 1024);
                }
                else
                {
                    BestFitAllocatation(PSize.Value * 1024);
                }
            }
            else if (Byte2.Checked == true)
            {
                if (FirstFit.Checked == true)
                {
                    FirstFitAllocatation(PSize.Value);
                }
                else
                {
                    BestFitAllocatation(PSize.Value);
                }
            }
            else
            {
                display("Error: you have to select size type ", 1);
            }
            Allocate.Enabled=true;
            PID.Text="P"+(ProcessId+1).ToString();
        }


        private void Reset_Click(object sender, EventArgs e)
        {
            HoleID = 0;
            ProcessId = 0;
            T.Rows.Clear();
            T.Columns.Clear();
            RAM.DataSource = T;
            holes.Clear();
            Global.intervals.Clear();
            Global.MemorySize = 0;
            PID.Text = "P1";
            FirstFit.Checked = false;
            BestFit.Checked = false;
            Holes.Enabled = false;
            MemorySize.Enabled = false;
            AllocateProcess.Enabled = false;
            Result.Visible = false;
            MemorySize.Enabled = true;
            display("The simulation is reset successfully", 0);

        }


        private void RAM_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.RAM.Rows[e.RowIndex];
                if (row.Cells["PID"].Value == "Hole")
                {
                    display("Error: you can't deallocate a hole ", 1);
                }
                else
                {
                    string v = row.Cells["PID"].Value.ToString();
                    v = v.Substring(1);
                    deallocatation(int.Parse(v));
                }
            }
        }

       

    }



    class interval : IComparable<interval>
    {
        public decimal begin;
        public decimal end;
        public decimal size;
        public int id;
        public interval()
        {
            begin = 0;
            end = 0;
            size = 0;
            id = -1;
        }
        public interval(decimal b, decimal e, decimal s, int i)
        {
            begin = b;
            end = e;
            size = s;
            id = i;
        }
        public int CompareTo(interval other)
        {
            return this.begin.CompareTo(other.begin);
        }

    }
    static class Global
    {
        public static List<interval> intervals = new List<interval>(50);
        public static decimal MemorySize = 0;
        public static decimal sizeofhole = 0;
    }

}