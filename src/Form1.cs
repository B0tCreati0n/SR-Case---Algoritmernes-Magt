using System.Diagnostics;

namespace SR_Case___Algoritmernes_Magt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_newPost_Click(object sender, EventArgs e)
        {
            Form2 newPostForm = new Form2();
            newPostForm.ShowDialog();
        }

        private void btn_skip_Click(object sender, EventArgs e)
        {
            int nextPost = Program.requstNewPostToFeed(Program.userId());
            if (nextPost <= 0) {
                if (GlobalConfig.debugMode == true)
                {
                    Debug.WriteLine("Debug Mode | nextPost value: " + nextPost);
                }
                MessageBox.Show("Error, try again or restart...");
                return;
            }
            MessageBox.Show($"{nextPost}");
            Program.displayPost(nextPost);
        }
    }
}
