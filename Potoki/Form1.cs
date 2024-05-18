namespace Potoki
{
    public partial class Form1 : Form
    {
        int i = 1;

        public Form1()
        {
            InitializeComponent();
            timer1.Start();
          
        }
        private void StartTimer() { 
            timer1.Start();


        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            i=hScrollBar1.Value;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Task task = Task.Run(() =>

            {
                while (true)
                {
                    try
                    {
                        this.Invoke(new EventHandler(delegate
                        {
                            textBox1.Text=button1.Left.ToString();
                            if (button1.Left <-1*(button1.Width))
                            {
                                button1.Left = 900;
                            }
                            button1.Left -= i;


                        }));
                    }catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);    
                    }
                    Thread.Sleep(100);

                }
            }

          );
        }
    }
}