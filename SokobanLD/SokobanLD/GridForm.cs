using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SokobanLD
{
    public partial class GridForm : Form
    {

        List<Slot> _slots = new List<Slot>();
        int _selectedColor = 1;


        public GridForm()
        {
            InitializeComponent();
        }
        public static string Result;

        private void GridForm_Load(object sender, EventArgs e)
        {
            int squareP = 30;
            int id = 0;

            for (int x = 0; x < Main.GridWidth; x++ ) 
            {
                for (int y = 0; y < Main.GridHeight; y++) 
                {
                    
                    Slot dynamicSlot = new Slot
                    {
                        Btn = new Button
                        {
                            Name = id.ToString(),
                            Height = squareP,
                            Width = squareP,
                            Location = new Point(x * squareP, y * squareP),
                            BackColor = Color.White
                        },
                        Index = 0,

                        Vector2 = new int[] {x, y}
                    };

                    dynamicSlot.Btn.Click += new EventHandler(DynamicButton_Click);
                    Controls.Add(dynamicSlot.Btn);
                    _slots.Add(dynamicSlot);

                    id++;
                }
            }
        }

        private void DynamicButton_Click(object sender, EventArgs e)
        {
            int id = int.Parse((sender as Button).Name);
            _slots[id].ChangeColor(_selectedColor);
        }

        private void free_Click(object sender, EventArgs e)
        {
            selectedColorButton.BackColor = Color.White;
            _selectedColor = 0;
        }

        private void wall_Click(object sender, EventArgs e)
        {
            selectedColorButton.BackColor = Color.Black;
            _selectedColor = 1;
        }

        private void player_Click(object sender, EventArgs e)
        {
            selectedColorButton.BackColor = Color.Blue;
            _selectedColor = 2;
        }

        private void point_Click(object sender, EventArgs e)
        {
            selectedColorButton.BackColor = Color.Red;
            _selectedColor = 3;
        }

        private void onPoint_Click(object sender, EventArgs e)
        {
            selectedColorButton.BackColor = Color.Orange;
            _selectedColor = 4;
        }

        private void item_Click(object sender, EventArgs e)
        {
            selectedColorButton.BackColor = Color.Green;
            _selectedColor = 5;
        }
        private void PlayerOnPoint_Click(object sender, EventArgs e)
        {
            selectedColorButton.BackColor = Color.Gray;
            _selectedColor = 6;
        }

        //Finish
        private void finish_Click(object sender, EventArgs e)
        {
            Result = string.Empty;
            for (int x = 0; x < Main.GridWidth; x++) 
            {
                for(int y = 0; y < Main.GridHeight; y++) 
                {
                    foreach (Slot item in _slots) 
                    {
                        if (item.Vector2[0] == x && item.Vector2[1] == y) 
                        {
                            Result += item.Index.ToString();
                        }
                    }
                }
            }
            this.Close();
        }
    }
    public class Slot
    {
        public enum SlotValue
        {
            Free = 0,
            Wall = 1,
            Player = 2,
            Point = 3,
            OnPoint = 4,
            Item = 5,
            PlayerOnPoint = 6
        }

        public Button Btn { get; set; }
        public int Index { get; set; }
        public int[] Vector2 { get; set; }

        public void ChangeColor(int index) 
        {
            switch(index) 
            {

                case (int) SlotValue.Free:
                    Btn.BackColor = Color.White;
                    Index = index;
                    break;

                case (int) SlotValue.Wall:
                    Btn.BackColor = Color.Black;
                    Index = index;
                    break;

                case (int) SlotValue.Player:
                    Btn.BackColor = Color.Blue;
                    Index = index;
                    break;

                case (int) SlotValue.Point:
                    Btn.BackColor = Color.Red;
                    Index = index;
                    break;

                case (int) SlotValue.OnPoint:
                    Btn.BackColor = Color.Orange;
                    Index = index;
                    break;

                case (int) SlotValue.Item:
                    Btn.BackColor = Color.Green;
                    Index = index;
                    break;
                case (int)SlotValue.PlayerOnPoint:
                    Btn.BackColor = Color.Gray;
                    Index = index;
                    break;
            }        
        }
    }
}
