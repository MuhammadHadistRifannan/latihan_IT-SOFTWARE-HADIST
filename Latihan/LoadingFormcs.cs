using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace latihanCRUD1
{
    public partial class LoadingFormcs : Form
    {
        int progress;
        bool loadingSuccess;
        public LoadingFormcs()
        {
            InitializeComponent();
        }

        private void Loading(object sender, EventArgs e)
        {
            Random randNumber = new Random();
            int randomSize = randNumber.Next(50, 100);
            progress += randomSize;

            //Set Loading Bar 
            handle.Size = new Size(progress, handle.Size.Height);

            try
            {
                if (handle.Size.Width > 587)
                {
                    loading_title.Text = "SUCCESFULLY";
                    update.Stop();
                    Scene.ChangeScene(new LoginPage());
                }
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
