using System.Data.SqlClient;
using System.IO;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
namespace WriteToSQLDB
{
    public partial class Form1 : Form
    {
        string connectionString = @"Data Source=.\SQLEXPRESS;Database=PersonDatabase;trusted_connection = true;";
        string selectedTable;
        int selectedID;
        bool update = false;
        bool savedirectory = false;
        string sqlDir = System.IO.File.ReadAllText($"{Directory.GetCurrentDirectory()}\\sqldirectory.txt");
        public Form1()
        {
            InitializeComponent();
            AcceptButton = searchTableButton;
            sqlDirTextBox.Text = sqlDir;
            using SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Integrated Security=True;trusted_connection = true;");
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                try
                {
                    cmd.Connection = con;
                    cmd.CommandText = "SELECT database_id FROM sys.databases WHERE Name = 'PersonDatabase'";
                    int result = Convert.ToInt32(cmd.ExecuteScalar());
                    if (result == 0)
                    {
                        cmd.CommandText = "CREATE DATABASE PersonDatabase ON PRIMARY " +
                             "(NAME = PersonDatabase, " +
                             $"FILENAME = '{sqlDir}MSSQL15.SQLEXPRESS\\MSSQL\\DATA\\PersonDatabase.mdf', " +
                             "SIZE = 2MB, MAXSIZE = 10MB, FILEGROWTH = 10%)" +
                             "LOG ON (NAME = PersonDatabase, " +
                             $"FILENAME = '{sqlDir}MSSQL15.SQLEXPRESS\\MSSQL\\DATA\\PersonDatabase.ldf', " +
                             "SIZE = 1MB, " +
                             "MAXSIZE = 5MB, " +
                             "FILEGROWTH = 10%);";
                        cmd.ExecuteNonQuery();

                    }
                }
                catch (Exception error)
                {
                    messageBox.Clear();
                    messageBox.ForeColor = Color.Red;
                    messageBox.AppendText(error.Message);
                }
                con.Close();
            }
            UpdateTableListBox();

        }
        public void UpdateTableListBox()
        {
            using SqlConnection con = new SqlConnection(connectionString);
            {
                SqlCommand cmd = new SqlCommand();
                con.Open();
                try
                {
                    tableListBox.Items.Clear();
                    cmd.Connection = con;
                    cmd.CommandText = "SELECT table_name FROM information_schema.tables;";
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        string name = (string)dr["table_name"];
                        string item = string.Format(name);

                        tableListBox.Items.Add(item);


                    }
                    dr.Close();
                }
                catch (Exception error)
                {
                    messageBox.Clear();
                    messageBox.ForeColor = Color.Red;
                    messageBox.AppendText(error.Message + "\n");

                }
                con.Close();
            }
        }


        private void submitButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(selectedTable))
            {
                SqlCommand cmd = new SqlCommand();
                try
                {
                    int result;
                    using SqlConnection con = new SqlConnection(connectionString);
                    {
                        string query;
                        if (!update)
                        {
                            query = QueryStringBuilder($"EXEC AddTo{selectedTable} ", false);
                        }
                        else
                        {
                            query = QueryStringBuilder($"EXEC Update{selectedTable} ", false);
                            query = query.Substring(0, query.Length - 1);
                            query += $", @ID = {selectedID};";
                        }
                        con.Open();
                        cmd.Connection = con;
                        cmd.CommandText = query;
                        result = cmd.ExecuteNonQuery();
                    }
                    if (result != 0)
                    {
                        messageBox.Clear();
                        messageBox.ForeColor = Color.Green;
                        messageBox.AppendText((selectedID == 0) ? $"Person tillagd i {selectedTable}.\n" : $"Person uppdaterad i {selectedTable}.\n");
                    }

                }
                catch (Exception error)
                {
                    messageBox.Clear();
                    messageBox.ForeColor = Color.Red;
                    messageBox.AppendText(error.Message);


                }
                messageBox.ScrollToCaret();
            }
            else
            {
                messageBox.Clear();
                messageBox.ForeColor = Color.Red;
                messageBox.AppendText("Ingen tabell vald.");
            }
        }
        private void addTableButton_Click(object sender, EventArgs e)

        {
            string input = newTableTextBox.Text;

            if (!string.IsNullOrEmpty(input))
            {
                if (input.Contains(' '))
                {
                    input = input.Replace(' ', '_');
                }
                using SqlConnection con = new SqlConnection(connectionString);
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    try
                    {
                        bool exists = false;
                        cmd.Connection = con;
                        cmd.CommandText = $"SELECT table_name FROM information_schema.tables WHERE table_name = '{input}';";
                        SqlDataReader dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            exists = true;
                        }
                        dr.Close();
                        if (!exists)
                        {
                            cmd.CommandText = $"CREATE TABLE {input}(ID INT IDENTITY(1,1) PRIMARY KEY, FirstName VARCHAR(40), LastName VARCHAR(40), FullName VARCHAR(80), " +
                                $"Address VARCHAR(40), Postalcode INT, City VARCHAR(40), Phonenumber VARCHAR(20));";
                            cmd.ExecuteNonQuery();
                            cmd.CommandText = $"CREATE PROC Search{input} " +
                                $"@fullName VARCHAR(80) = '%'," +
                                $"@address VARCHAR(40) = '%'," +
                                $"@postalCode1 INT = 0," +
                                $"@postalCode2 INT = 100000," +
                                $"@city VARCHAR(40) = '%'," +
                                $"@phoneNumber VARCHAR(40) = '%'" +
                                $"AS " +
                                $"SELECT ID, FirstName, LastName, Address, PostalCode, City, Phonenumber FROM {input} " +
                                $"WHERE " +
                                $"FullName LIKE @fullName AND " +
                                $"Address LIKE @address AND " +
                                $"PostalCode between @postalCode1 AND @Postalcode2 AND " +
                                $"City LIKE @city AND " +
                                $"Phonenumber like @phoneNumber; ";
                            cmd.ExecuteNonQuery();
                            cmd.CommandText = $"CREATE PROC AddTo{input} @firstName VARCHAR(40) = '*'," +
                                $"@lastName VARCHAR(40) = '*'," +
                                $"@address VARCHAR(40) = '*'," +
                                $"@postalCode INT = 99999," +
                                $"@city VARCHAR(40) = '*'," +
                                $"@phoneNumber VARCHAR(40) = '*'" +
                                $"AS " +
                                $"INSERT INTO {input}(FirstName, LastName, FullName, Address, Postalcode, City, Phonenumber) " +
                                $"VALUES(@firstName, @lastName, (@firstName + ' ' + @lastName) , @address, @postalCode, @city, @phoneNumber);";
                            cmd.ExecuteNonQuery();
                            cmd.CommandText = $"CREATE PROC Update{input} @firstName VARCHAR(40) = '*'," +
                                $"@lastName VARCHAR(40) = '*'," +
                                $"@address VARCHAR(40) = '*'," +
                                $"@postalCode INT = 99999," +
                                $"@city VARCHAR(40) = '*'," +
                                $"@phoneNumber VARCHAR(40) = '*'," +
                                $"@ID int " +
                                $"AS " +
                                $"UPDATE {input} " +
                                $"SET FirstName = @firstname, LastName = @LastName, FullName = (@firstName + ' ' + @lastName), " +
                                $"Address = @address, Postalcode = @postalCode, City = @city, Phonenumber = @phoneNumber " +
                                $"WHERE ID = @ID;";
                            cmd.ExecuteNonQuery();
                            cmd.CommandText = $"CREATE PROC DeleteFrom{input} @ID int AS DELETE FROM {input} WHERE ID = @ID;";
                            cmd.ExecuteNonQuery();
                            cmd.CommandText = $"CREATE PROC DeleteTable{input} AS DROP TABLE {input}; DROP PROCEDURE AddTo{input}; DROP PROCEDURE Search{input}; " +
                                $"DROP PROCEDURE DeleteFrom{input}; DROP PROCEDURE Update{input}; ";
                            cmd.ExecuteNonQuery();
                            tableListBox.Items.Add(input);
                            messageBox.Clear();
                            messageBox.ForeColor = Color.Green;
                            messageBox.AppendText($"Tabell {input} skapad!\n");


                        }
                        else
                        {
                            messageBox.Clear();
                            messageBox.ForeColor = Color.Blue;
                            messageBox.AppendText("Tabellen finns redan\n");

                        }


                    }
                    catch (Exception error)
                    {
                        messageBox.Clear();
                        messageBox.ForeColor = Color.Red;
                        messageBox.AppendText(error.Message + "\n");


                    }
                    con.Close();
                }
            }

            else
            {
                messageBox.ForeColor = Color.Blue;
                messageBox.AppendText("Fyll i ett namn på tabellen.\n");


            }
            UpdateTableListBox();
            tableListBox.SelectedItem = input;

        }
        private void dataBaseListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dataBaseListBox_SelectedIndexChanged != null)
            {
                selectedTable = tableListBox.SelectedItem.ToString();
                tableLabel.Text = selectedTable;
                searchTableButton.Enabled = true;
                submitButton.Enabled = true;
                deleteTableButton.Enabled = true;

            }
        }
        private void messageBox_TextChanged(object sender, EventArgs e)
        {

        }


        private void tableLabel_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tableLabel.Text))
            {
                tableLabel.Text = "Ej vald";
                tableLabel.Font = new Font("Segoe", 14, FontStyle.Italic);
                tableLabel.ForeColor = Color.Gray;
            }
            else
            {
                tableLabel.Font = new Font("Segoe", 14);
                tableLabel.ForeColor = Color.Black;
            }

        }



        private void deleteTableButton_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show($"Vill du verkligen radera {selectedTable}?", "Radera tabell", buttons);
            if (result == DialogResult.Yes)
            {
                using SqlConnection con = new SqlConnection(connectionString);
                {
                    SqlCommand cmd = new SqlCommand();
                    con.Open();
                    try
                    {
                        cmd.Connection = con;
                        cmd.CommandText = $"EXEC DeleteTable{selectedTable};";
                        cmd.ExecuteNonQuery();
                        cmd.CommandText = $"DROP PROCEDURE DeleteTable{selectedTable}";
                        cmd.ExecuteNonQuery();
                        messageBox.ForeColor = Color.Green;
                        messageBox.Clear();
                        messageBox.AppendText($"Tabellen '{selectedTable}' borttagen från databasen.\n");
                        selectedTable = null;
                        deleteTableButton.Enabled = false;
                        tableLabel.Text = "";
                    }
                    catch (Exception error)
                    {
                        messageBox.Clear();
                        messageBox.ForeColor = Color.Red;
                        messageBox.AppendText(error.Message + "\n");

                    }
                    con.Close();
                }
                submitButton.Enabled = false;
                searchTableButton.Enabled = false;
                UpdateTableListBox();
            }

        }

        private void searchTableButton_Click(object sender, EventArgs e)
        {
            string query = QueryStringBuilder($"EXEC Search{selectedTable} ", true);

            using SqlConnection con = new(connectionString);
            {
                con.Open();
                try
                {
                    searchResultTextBox.Clear();
                    idListBox.Items.Clear();
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        int id = (int)dr["ID"];
                        string firstname = (string)dr["FirstName"];
                        string lastname = (string)dr["LastName"];
                        string address = (string)dr["Address"];
                        int postalcode = (int)dr["PostalCode"];
                        string city = (string)dr["City"];
                        string phonenumber = (string)dr["Phonenumber"];
                        string item = $"ID: {id}\nFörnamn: {firstname}\nEfternamn: {lastname}\nAdress:\n{address}\n{postalcode} {city}\nTelefonnummer: {phonenumber}";
                        idListBox.Items.Add(id);
                        searchResultTextBox.AppendText(item + "\n\n");


                    }
                    dr.Close();
                    messageBox.Clear();
                    messageBox.ForeColor = Color.Green;
                    messageBox.AppendText("Sökning lyckades. Se resultat till höger." + "\n");


                }
                catch (Exception error)
                {
                    messageBox.Clear();
                    messageBox.ForeColor = Color.Red;
                    messageBox.AppendText(error.Message + "\n");

                }
                con.Close();

            }
            submitButton.ForeColor = Color.Green;
            submitButton.Text = "Spara i tabell";
            selectedID = 0;
            importIDButton.Enabled = false;
            deleteIDButton.Enabled = false;
        }

        private string QueryStringBuilder(string query, bool isSearch)
        {
            if (!string.IsNullOrEmpty(nameTextBox.Text))
            {
                string nameInput = nameTextBox.Text.Trim();
                string firstName = "";
                string lastName = "";

                if (isSearch)
                {
                    query += $"@fullName = '%{nameInput}%'";
                }
                else
                {
                    if (nameInput.Contains(' '))
                    {
                        int indexOfFirstSpace = nameInput.IndexOf(' ');
                        firstName = nameInput.Substring(0, indexOfFirstSpace);
                        lastName = nameInput.Substring(indexOfFirstSpace + 1);
                        query += $"@firstName = '{firstName}', @lastName = '{lastName}'";
                    }
                    else
                    {
                        query += $"@firstName = '{nameInput}'";
                    }
                }

            }
            else
            {
                query += isSearch ? "@fullName = '%'" : "@firstName = '*', @lastName = '*'";
            }
            if (!string.IsNullOrEmpty(addressTextBox.Text))
            {
                query += isSearch ? $", @address = '%{addressTextBox.Text}%'" : $", @address = '{addressTextBox.Text}'";
            }
            if (!string.IsNullOrEmpty(postalCodeTextBox.Text) && int.TryParse(postalCodeTextBox.Text, out int postalCode))
            {
                query += isSearch ? $", @postalCode1 = {postalCode}, @postalCode2 = {postalCode}" : $", @postalcode = {postalCode}";
            }
            if (!string.IsNullOrEmpty(cityTextBox.Text))
            {
                query += isSearch ? $", @city = '%{cityTextBox.Text}%'" : $", @city = '{cityTextBox.Text}'";
            }
            if (!string.IsNullOrEmpty(phoneTextBox.Text))
            {
                query += isSearch ? $", @phoneNumber = '%{phoneTextBox.Text}%'" : $", @phoneNumber = '{phoneTextBox.Text}'";
            }
            query += ";";
            return query;
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void idListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedID = Convert.ToInt32(idListBox.SelectedItem);
            importIDButton.Enabled = true;
            deleteIDButton.Enabled = true;
        }

        private void importIDButton_Click(object sender, EventArgs e)
        {
            using SqlConnection con = new(connectionString);
            {
                string query = $"SELECT * FROM {selectedTable} WHERE ID = {selectedID}";
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        int id = (int)dr["ID"];
                        string firstname = (string)dr["FirstName"];
                        string lastname = (string)dr["LastName"];
                        string address = (string)dr["Address"];
                        int postalcode = (int)dr["PostalCode"];
                        string city = (string)dr["City"];
                        string phonenumber = (string)dr["Phonenumber"];
                        nameTextBox.Text = $"{firstname} {lastname}";
                        addressTextBox.Text = address;
                        postalCodeTextBox.Text = $"{postalcode}";
                        cityTextBox.Text = city;
                        phoneTextBox.Text = phonenumber;


                    }
                    dr.Close();

                }
                catch (Exception error)
                {
                    messageBox.Clear();
                    messageBox.ForeColor = Color.Red;
                    messageBox.AppendText(error.Message + "\n");

                }
                con.Close();

            }
            submitButton.ForeColor = Color.Blue;
            submitButton.Text = "Uppdatera befintlig";
            update = true;

        }

        private void emptyFieldsButton_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
        private void ClearAll()
        {
            nameTextBox.Clear();
            addressTextBox.Clear();
            postalCodeTextBox.Clear();
            cityTextBox.Clear();
            phoneTextBox.Clear();
            idListBox.ClearSelected();
            selectedID = 0;
            importIDButton.Enabled = false;
            deleteIDButton.Enabled = false;
            submitButton.ForeColor = Color.Green;
            submitButton.Text = "Spara i tabell";
            update = false;
        }

        private void tableLabel_Click(object sender, EventArgs e)
        {

        }

        private void deleteIDButton_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show($"Vill du verkligen radera ID {selectedID} från {selectedTable}?", "Radera person", buttons);
            if (result == DialogResult.Yes)
            {
                messageBox.Clear();
                using SqlConnection con = new SqlConnection(connectionString);
                {
                    SqlCommand cmd = new SqlCommand();
                    try
                    {
                        con.Open();
                        cmd.Connection = con;
                        cmd.CommandText = $"EXEC DeleteFrom{selectedTable} @ID = {selectedID};";
                        cmd.ExecuteNonQuery();
                        searchTableButton.PerformClick();
                        messageBox.Clear();
                        messageBox.ForeColor = Color.Green;
                        messageBox.AppendText($"ID: {selectedID} borttagen från tabell: {selectedTable}");

                    }
                    catch (Exception error)
                    {
                        messageBox.ForeColor = Color.Red;
                        messageBox.Text = error.Message;

                    }
                    con.Close();

                }
               
            }
        }
        private void changeDirButton_Click(object sender, EventArgs e)
        {
            if (sqlDirTextBox.Enabled == false)
            {
                changeDirButton.Text = "Ångra";
                sqlDirTextBox.Enabled = true;
                
            }
            else
            {                
                changeDirButton.Text = "Ändra";
                sqlDirTextBox.Enabled = false;
                if (savedirectory)
                {
                    System.IO.File.WriteAllText($"{Directory.GetCurrentDirectory()}\\sqldirectory.txt", sqlDirTextBox.Text);
                    Application.Restart();
                    Environment.Exit(0);
                }
            }
        }
        
        private void sqlDirTextBox_TextChanged(object sender, EventArgs e)
        {
            if (sqlDirTextBox.Enabled)
            {
                changeDirButton.Text = "Spara";
                savedirectory = true;
            }
        }
    }
}