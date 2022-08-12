using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageUpload
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void image_UploadsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.image_UploadsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.userLoginDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'userLoginDataSet.Image_Uploads' table. You can move, or remove it, as needed.
            this.image_UploadsTableAdapter.Fill(this.userLoginDataSet.Image_Uploads);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFd = new OpenFileDialog();
            openFd.Filter = "Images only. | *.jpg; *.jpeg; *.png; *.gif;";
            DialogResult dr = openFd.ShowDialog();
            imgPictureBox.Image = Image.FromFile(openFd.FileName);
            imgpathLabel1.Text = openFd.FileName;

        }
    }
}
