using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toplivo1
{
    public partial class FormTank : Form
    {

        private string strPictureDir="\\TankPictures\\";
        public FormTank()
        {
            InitializeComponent();
        }

        private void tanksBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tanksBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.toplivo_DataSet);

        }

        private void FormTank_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "toplivo_DataSet.Tanks". При необходимости она может быть перемещена или удалена.
            this.tanksTableAdapter.Fill(this.toplivo_DataSet.Tanks);
            string strPicturePath = TankPictureBox.Tag.ToString();
            //Считывание изображения из каталога strPictureDir и отображение его на форме
            strPicturePath = Directory.GetCurrentDirectory() + strPictureDir + strPicturePath;
            if (File.Exists(strPicturePath))
            {
                TankPictureBox.Image = Image.FromFile(strPicturePath);

            }
            
        }

        private void FormTank_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        
    }
}
