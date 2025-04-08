namespace PizzaDeliverySystem
{
    public partial class UserForm : Form
    {
        UserDb _userDb;
        public UserForm()
        {
            InitializeComponent();
            _userDb = new UserDb("Data Source=pizza.db");
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            var username = unameTxt.Text;
            var password = passTxt.Text;

            (int id, string username, string password, bool isAdmin) user;

            try
            {
                user = _userDb.GetUser(username);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            if (Hashing.CheckPasswordHash(password, user.password))
            {
                if (user.isAdmin)
                {
                    this.Hide();
                    AdminForm adminForm = new AdminForm();
                    adminForm.Show();
                }
                else
                {
                    this.Hide();
                    MainForm mainForm = new MainForm(user.id);
                    mainForm.Show();
                }

                MessageBox.Show("Logged in!");
            }
            else
            {
                MessageBox.Show("Incorrect login or password!");
            }
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationForm registerForm = new RegistrationForm();
            registerForm.Show();
        }
    }
}