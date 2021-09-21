using System.Windows.Forms;

namespace OpsMoi
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }
        
        public delegate void toSplashFunc();
        public static void SplashFunc(toSplashFunc toFunc)
        {
            SplashForm sp = new SplashForm(); 
            sp.Show();
            sp.Update();
            toFunc();
            sp.Hide();
        }
    }
}
