namespace Minigame_Launcher
{
    public partial class form_start : Form
    {
        public form_start()
        {
            InitializeComponent();
        }
        // ����� ��� ��������� ��������� � ������ ���������
        private void form_start_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { but_exit.PerformClick(); }
            else if (e.KeyCode == Keys.NumPad1) { but_rps_start.PerformClick(); }
            else if (e.KeyCode == Keys.NumPad3) { but_ttt_start.PerformClick(); }
        }
        // ����� ������ �������� �� ����� ������-������-������
        private void but_rps_start_Click(object sender, EventArgs e)
        {
            form_rps form_Rps = new form_rps(); // ��������� ������� ����� ������-������-������
            form_Rps.Show(); // ���������� ����� ������-������-������
            this.Hide(); // �������� ������� �����
        }
        // ����� ������ �������� �� ����� ��������-�������
        private void but_ttt_start_Click(object sender, EventArgs e)
        {
            form_ttt form_ttt = new form_ttt(); // ��������� ������� ����� ��������-�������
            form_ttt.Show(); // ���������� ����� ��������-�������
            this.Hide(); // �������� ������� �����
        }
        // ����� ������ �������� ��������
        private void but_exit_Click(object sender, EventArgs e)
        {
            Application.ExitThread(); // ���� Application �� ���� ����� ExitThread ������� �� ������ ����� �� �������
        }
    }
}