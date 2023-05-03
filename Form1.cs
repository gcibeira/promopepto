using Microsoft.VisualBasic;
using System.Text.RegularExpressions;

namespace promopepto
{
    public partial class Form1 : Form
    {
        List<Client> clients;
        Logger logger;
        Database db;

        public Form1()
        {
            InitializeComponent();
            string db_path = Properties.Settings.Default.db_path;
            string logger_path = Properties.Settings.Default.logger_path;

            if (!File.Exists(db_path))
            {
                using (var dialog = new SaveFileDialog())
                {
                    dialog.Filter = "JSON Files (*.json)|*.json";
                    dialog.Title = "Choose a location to save the database file";
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        db_path = dialog.FileName;
                        if (!File.Exists(dialog.FileName))
                            File.WriteAllText(db_path, "[]");
                        Properties.Settings.Default.db_path = db_path;
                        Properties.Settings.Default.Save();
                    }
                }
            }

            if (!File.Exists(logger_path))
            {
                using (var dialog = new SaveFileDialog())
                {
                    dialog.Filter = "Log Files (*.log)|*.log";
                    dialog.Title = "Choose a location to save the logger file";
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        logger_path = dialog.FileName;
                        if (!File.Exists(logger_path))
                            File.WriteAllText(logger_path, "");
                        Properties.Settings.Default.logger_path = logger_path;
                        Properties.Settings.Default.Save();
                    }
                }
            }

            logger = new(logger_path);
            db = new(db_path);
            clients = db.Load<Client>();
            logger.Log("new session opened");

            dataGridView1.DataSource = clients;
            dataGridView1.Columns["Name"].HeaderText = "Nome";
            dataGridView1.Columns["Credits"].HeaderText = "Punti";
            UpdateList();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string name = Interaction.InputBox("Inserire il nome del nuovo cliente", "Nuovo Cliente");
            name = Regex.Replace(name, @"\s+", " ").Trim();
            if (name.Length <= 0)
            {
                return;
            }

            if (clients.Find(x => x.Name.ToLower() == name.ToLower()) != null)
            {
                MessageBox.Show($"Il cliente {name} essite giá", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Client newClient = new Client(name);
            clients.Add(newClient);
            UpdateList();
            db.Save(clients);
            logger.Log($"new client {name} created");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            UpdateList();
            UpdateValues();
        }


        private void listBoxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateValues();
        }

        private void buttonIncrement_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                Client selectedClient = (Client)dataGridView1.CurrentRow.DataBoundItem;
                selectedClient.IncrementCredits();
                db.Save(clients);
                logger.Log($"{selectedClient.Name} +1 credit. New value = {selectedClient.Credits}");
            }
            UpdateValues();
            dataGridView1.Refresh();
        }

        private void buttonDecrement_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                Client selectedClient = (Client)dataGridView1.CurrentRow.DataBoundItem;
                selectedClient.DecrementCredits();
                db.Save(clients);
                logger.Log($"{selectedClient.Name} -1 credit. New value = {selectedClient.Credits}");
            }
            UpdateValues();
            dataGridView1.Refresh();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                Client selectedClient = (Client)dataGridView1.CurrentRow.DataBoundItem;
                DialogResult result = MessageBox.Show($"Ripristinare i punti di {selectedClient.Name}. Sei sicuro?", "Reset punti", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    selectedClient.ResetCredits();
                    db.Save(clients);
                    logger.Log($"{selectedClient.Name} credits reset. New value = {selectedClient.Credits}");
                }
            }
            UpdateValues();
            dataGridView1.Refresh();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                Client selectedClient = (Client)dataGridView1.CurrentRow.DataBoundItem;
                DialogResult result = MessageBox.Show($"Cancellare {selectedClient.Name}. Sei sicuro?", "Cancellare cliente", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    clients.Remove(selectedClient);
                    UpdateList();
                    db.Save(clients);
                    logger.Log($"client {selectedClient.Name} removed");
                }
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            UpdateValues();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            var textBox = (TextBox)sender;
            textBox.SelectAll();
            textBox.Focus();
        }

        private void UpdateList()
        {
            List<Client> filteredList = clients.FindAll(client => client.Name.ToLower().Contains(textBox1.Text.ToLower()));
            filteredList.Sort((c1, c2) => c1.Name.CompareTo(c2.Name));
            labelCount.Text = $"Mostrando {filteredList.Count} di {clients.Count}";
            dataGridView1.DataSource = filteredList;
        }

        private void UpdateValues()
        {
            if (dataGridView1.CurrentRow != null)
            {
                Client selectedClient = (Client)dataGridView1.CurrentRow.DataBoundItem;
                labelName.Text = selectedClient.Name;
                labelCredits.Text = selectedClient.Credits.ToString();
                progressBarCredits.Value = selectedClient.Credits * 10;
            }
            else
            {
                labelName.Text = "";
                labelCredits.Text = "";
                progressBarCredits.Value = 0;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            logger.Log("session closed");
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Credits" && Convert.ToInt32(e.Value) >= 10)
            {
                e.CellStyle.BackColor = Color.LightGreen;
            }
        }
    }
}