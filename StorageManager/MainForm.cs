namespace StorageManager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            // Здесь будут все уведомления для юзера/админа + панель доступа в другие формы 
            InitializeComponent();
            this.MinimumSize = new Size(800, 600);
            this.MaximumSize = new Size(800, 600);


        }
    }
}