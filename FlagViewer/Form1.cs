using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlagViewer
{
    public partial class FlagViewer : Form
    {
        private int currentImageIndex;


        public FlagViewer()
        {
            InitializeComponent();
        }

        private void FlagViewer_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = imageList1.Images[0]; // load first image
        }

        // Mod function to support negative values (for the back button).
        int mod(int a, int b)
        {
            return (a % b + b) % b;
        }

        // Show the next picture in the PictureBox.
        private void Next_Click(object sender, EventArgs e)
        {
            currentImageIndex = mod(currentImageIndex + 1, imageList1.Images.Count);
            pictureBox1.Image = imageList1.Images[currentImageIndex];
            listBox1.SelectedIndex = currentImageIndex;
            label1.Text = "Country: " + listBox1.Text;
        }

        // Show the previous picture in the PictureBox.
        private void Previous_Click(object sender, EventArgs e)
        {
            currentImageIndex = mod(currentImageIndex - 1, imageList1.Images.Count);
            pictureBox1.Image = imageList1.Images[currentImageIndex];
            listBox1.SelectedIndex = currentImageIndex;
            label1.Text = "Country: " + listBox1.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
