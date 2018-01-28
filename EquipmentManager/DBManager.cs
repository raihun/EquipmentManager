using System;
using System.Collections.Generic;
using System.Data; // DataTable
using System.Data.SQLite; // SQLiteConnection, SQLiteDataAdapter
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; // Application, MessageBox

namespace EquipmentManager {
    class DBManager {

        private DataTable dataTable { get; set; }
        private SQLiteConnection con { get; set; }
        private SQLiteDataAdapter adapter { get; set; }

        public DataTable load() {
            string path = Application.StartupPath + @"\Data.db";
            using (this.con = new SQLiteConnection("Data Source=" + path)) {
                this.dataTable = new DataTable();

                this.adapter = new SQLiteDataAdapter("SELECT * FROM equipment;", this.con);
                this.adapter.Fill(this.dataTable);

                return this.dataTable;
            }
        }

        public void update() {
            try {
                using (SQLiteTransaction tran = this.con.BeginTransaction()) {
                    SQLiteCommandBuilder builder = new SQLiteCommandBuilder(this.adapter);
                    builder.SetAllValues = false;
                    builder.ConflictOption = ConflictOption.OverwriteChanges;

                    this.adapter.Update(this.dataTable);
                    tran.Commit();
                }
            } catch(Exception e) {
                MessageBox.Show(e.Message, "Error");
            }
        }
    }
}
