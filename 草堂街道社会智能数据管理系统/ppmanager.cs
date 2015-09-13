using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using 草堂街道社会智能数据管理系统.ComClass;
using 草堂街道社会智能数据管理系统.dataClass;

namespace 草堂街道社会智能数据管理系统
{
    public partial class ppmanager : Form
    {
        private readonly CommonUse commUse = new CommonUse();
        private readonly DataBase db = new DataBase();
 

        public ppmanager()
        {
            InitializeComponent();
        

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void 添加人员ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            CommonUse commUse = new CommonUse();
            var x = (ToolStripMenuItem)sender;

            commUse.ShowForm(x.Tag.ToString(), this.main);
        }


        private string sqlcmd = "SELECT district.`name` AS nd, grid.`name` AS ng, block.`name` AS nb, population.card_id AS cid, population.`name` AS na,population.address AS ad, "
           + "CASE population.educational WHEN '党员' THEN '是' ELSE '否' end AS edu,"
           + "CASE features.vip when true then '是' ELSE '否'end AS vip,"
            + "CASE features.cleaner when true then '是' ELSE '否'end AS cle,"
            + "CASE features.old when true then '是' ELSE '否'end AS old,"
            + "CASE features.old_alone when true then '是' ELSE '否'end AS olda,"
            + "CASE features.poor when true then '是' ELSE '否'end AS poor,"
            + "CASE features.handicapped when true then '是' ELSE '否'end AS hand,"
            + "CASE features.resident when resident then '是' ELSE '否'end AS res,"
            + "CASE features.unjob when true then '是' ELSE '否'end AS unjob,"
            + "CASE features.dope when true then '是' ELSE '否'end AS dope,"
            + "CASE features.correction when true then '是' ELSE '否'end AS cor,"
            + "CASE features.released when true then '是' ELSE '否'end AS rel,"
            + "CASE features.foreigner when true then '是' ELSE '否'end AS fore FROM district INNER JOIN grid ON grid.district = district.id INNER JOIN block ON block.grid = grid.id INNER JOIN population ON population.block = block.id INNER JOIN features ON population.features = features.id ";

        private void ppmanager_Load(object sender, EventArgs e)
        {
           
            List<item> items = new List<item>();
            MySqlDataReader sdr;
            sdr = db.GetDataReader("SELECT district.`name`,district.`id` FROM district");
            while (sdr.Read())
            {
                item it = new item(sdr[0].ToString(), sdr[1].ToString());
                items.Add(it);
            }
            sssq_cb.DataSource = items;
            //   items.Clear();
            sdr.Close();
            sdr = db.GetDataReader("SELECT 	grid.`name`,grid.id FROM district INNER JOIN grid ON grid.district = district.id WHERE district.id = 1");
            while (sdr.Read())
            {
                item it = new item(sdr[0].ToString(), sdr[1].ToString());
                items.Add(it);
            }
            sswg_cb.DataSource = items;
            //  items.Clear();
            sdr.Close();
            sdr = db.GetDataReader("SELECT 	block.`name`,block.id FROM grid INNER JOIN block ON block.grid = grid.id WHERE grid.id = 1");
            while (sdr.Read())
            {
                item it = new item(sdr[0].ToString(), sdr[1].ToString());
                items.Add(it);
            }
            ssyl_cb.DataSource = items;
            //  items.Clear();
            sdr.Close();
            
            if (this.Tag.ToString() != null)
            {
                switch (this.Tag.ToString())
                {
                    case "m1":
                        {
                            sqlcmd += "WHERE population.educational = '党员'" ;
                        }
                        break;
                    case "m2":
                        {
                            sqlcmd += "WHERE features.old IS NOT NULL";
                        }
                        break;
                    case "m3":
                        {
                            sqlcmd += "WHERE features.old >= 1 AND features.old_alone >= 1 ";
                        }
                        break;
                    case "m4":
                        {
                            sqlcmd += "WHERE features.handicapped >= 1";
                        }
                        break;
                    case "m5":
                        {
                            sqlcmd += "WHERE features.handicapped >= 1";
                        }
                        break;
                    case "m6":
                        {
                            sqlcmd += "WHERE features.poor >= 1";
                        }
                        break;
                    case "m7":
                        {
                            sqlcmd += "WHERE features.foreigner >= 1";
                        }
                        break;
                    case "m8":
                        {
                            sqlcmd += "WHERE features.poor >= 1";
                        }
                        break;
                    case "m9":
                        {
                            sqlcmd += "WHERE features.poor >= 1";
                        }
                        break;
                    case "m10":
                        {
                            sqlcmd += "WHERE features.cleaner >= 1 ";
                        }
                        break;
                    case "m11":
                        {
                            sqlcmd += "WHERE features.vip >= 1";
                        }
                        break;
                    case "m12":
                        {
                            sqlcmd += "WHERE features.unjob >= 1";
                        }
                        break;
                    case "m13":
                        {
                            sqlcmd += "WHERE features.dope >= 1";
                        }
                        break;
                    case "m14":
                        {
                            sqlcmd += "WHERE features.correction >= 1";
                        }
                        break;
                    case "m15":
                        {
                            sqlcmd += "WHERE features.released >= 1";
                        }
                        break;
                    default:
                        break;
                }
                dgv.DataSource = db.GetDataSet(sqlcmd, "t").Tables["t"];
            }
        }

        private void sssq_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            commUse.district_gird_block(sssq_cb, sswg_cb, "district", "grid");
        }

        private void sswg_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            commUse.district_gird_block(sswg_cb, ssyl_cb, "grid", "block");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Excel.ExportExcel excel = new Excel.ExportExcel();

            excel.CreateExcel();
            excel.CreateWorkSheet("人员导出信息");
            // 第一行加粗
            excel.FontStyle(1, 1, 1, 19, true, false, Excel.UnderlineStyle.无下划线);
            //p.CellsUnite(1, 1, 1, 5);
            // 表格数据

            // Excel第一行数据
            excel.WriteData("姓名", 1, 1);
            excel.WriteData("身份证", 1, 2);
            excel.WriteData("所属网络", 1, 3);
            excel.WriteData("所属院落", 1, 4);
            excel.WriteData("所属社区", 1, 5);
            excel.WriteData("居住地址", 1, 6);
            excel.WriteData("党员", 1, 7);
            excel.WriteData("常住人员", 1, 8);
            excel.WriteData("残疾人", 1, 9);
            excel.WriteData("老年人", 1, 10);
            excel.WriteData("空巢老人", 1, 11);
            excel.WriteData("境外人员", 1, 12);
            excel.WriteData("失业人员", 1, 13);
            excel.WriteData("重要人员", 1, 14);
            excel.WriteData("清洁人员", 1, 15);
            excel.WriteData("矫正人员", 1, 16);
            excel.WriteData("刑满人员", 1, 17);
            excel.WriteData("低保人员", 1, 18);
            excel.WriteData("吸毒人员", 1, 19);

            DataTable outDatatable = new DataTable();
            outDatatable.Columns.Add("name");
            outDatatable.Columns.Add("cardid");
            outDatatable.Columns.Add("district");
            outDatatable.Columns.Add("grid");
            outDatatable.Columns.Add("block");
            outDatatable.Columns.Add("ad");
            outDatatable.Columns.Add("member");
            outDatatable.Columns.Add("resident");
            outDatatable.Columns.Add("handicapped");
            outDatatable.Columns.Add("old");
            outDatatable.Columns.Add("alone");
            outDatatable.Columns.Add("jwry");
            outDatatable.Columns.Add("syry");
            outDatatable.Columns.Add("vip");
            outDatatable.Columns.Add("clear");
            outDatatable.Columns.Add("correction");
            outDatatable.Columns.Add("released");
            outDatatable.Columns.Add("poor");
            outDatatable.Columns.Add("dope");

            for (int i = 0; i < dgv.Rows.Count; i++)
            {

                DataRow newRow = outDatatable.NewRow();
                newRow["name"] = dgv.Rows[i].Cells["name"].Value;
                newRow["cardid"] = dgv.Rows[i].Cells["cardid"].Value;
                newRow["district"] = dgv.Rows[i].Cells["district"].Value;
                newRow["grid"] = dgv.Rows[i].Cells["grid"].Value;
                newRow["block"] = dgv.Rows[i].Cells["block"].Value;
                newRow["ad"] = dgv.Rows[i].Cells["ad"].Value;
                newRow["member"] = dgv.Rows[i].Cells["member"].Value;
                newRow["resident"] = dgv.Rows[i].Cells["resident"].Value;
                newRow["handicapped"] = dgv.Rows[i].Cells["handicapped"].Value;
                newRow["old"] = dgv.Rows[i].Cells["old"].Value;
                newRow["alone"] = dgv.Rows[i].Cells["alone"].Value;
                newRow["jwry"] = dgv.Rows[i].Cells["jwry"].Value;
                newRow["syry"] = dgv.Rows[i].Cells["syry"].Value;
                newRow["vip"] = dgv.Rows[i].Cells["vip"].Value;
                newRow["clear"] = dgv.Rows[i].Cells["clear"].Value;
                newRow["correction"] = dgv.Rows[i].Cells["correction"].Value;
                newRow["released"] = dgv.Rows[i].Cells["released"].Value;
                newRow["poor"] = dgv.Rows[i].Cells["poor"].Value;
                newRow["dope"] = dgv.Rows[i].Cells["dope"].Value;
                outDatatable.Rows.Add(newRow);
            }

            excel.WriteData(outDatatable, 2, 1);
            excel.Close(true, "bbb.xlsx");
        }

        private void search_Click(object sender, EventArgs e)
        {
            string tempSql = (sqlcmd + " where 1=1 ");

          
            // 姓名
            if (txtUserName.Text != null && txtUserName.Text.Trim().Length > 0) {
                tempSql += "and population.`name`='" + txtUserName.Text + "'";
            }

            // 身份证
            if (txtIdCard.Text != null && txtIdCard.Text.Trim().Length > 0)
            {
                tempSql += "and population.card_id ='" + txtIdCard.Text + "'";
            }

            if(sssq_cb.SelectedIndex != -1) {
                tempSql += " and district.id=" + (sssq_cb.SelectedIndex+1);
            }

            if (sswg_cb.SelectedValue != null)
            {
                tempSql += " and grid.name='"+ sswg_cb.SelectedValue + "'";
            }

            if (ssyl_cb.SelectedValue != null)
            {
                tempSql += " and block.name='" + ssyl_cb.SelectedValue + "'";
            }

            if (ckb_liudong.Checked) {
                tempSql += " and features.resident is null";
            }

            if (ckb_changzhu.Checked)
            {
                tempSql += " and features.resident is not null";
            }

            if (ckb_canjiren.Checked)
            {
                tempSql += " and features.handicapped is not null";
                // TODO
                if (cbk_mind.Checked) {
                    tempSql += " and exists(select id from handicapped where handicapped_type =0 and id = features.handicapped)";
                }
            }

            // 老年人
            if (ckb_oldman.Checked)
            {
                tempSql += " and features.old is not null";

                if (ckb_kongchao.Checked) {
                    tempSql += " and features.old_alone is not null";
                }
            }

            // 境外人员
            if (ckb_jwry.Checked)
            {
                tempSql += " and features.foreigner is not null";
            }

            // 矫正人员
            if (ckb_correction.Checked)
            {
                tempSql += " and features.correction is not null";
            }

            // 刑满人员
            if (ckb_released.Checked)
            {
                tempSql += " and features.released is not null";
            }

            // 低保人员
            if (ckb_poor.Checked)
            {
                tempSql += " and features.poor is not null";
            }

            // 吸毒人员
            if (ckb_dope.Checked)
            {
                tempSql += " and features.dope is not null";
            }
            // 清洁人员
            if (ckb_clean.Checked)
            {
                tempSql += " and features.cleaner =1";
            }

            // 失业人员
            if (ckb_dope.Checked)
            {
                tempSql += " and features.unjob is not null";
            }

            // 重要人员
            if (ckb_vip.Checked)
            {
                tempSql += " and features.vip =1";
            }

            // 党员
            if (ckb_educational.Checked)
            {
                tempSql += " and population.educational ='党员'";
            }

            dgv.DataSource = db.GetDataSet(tempSql, "t").Tables["t"];
        }

        private void ckb_canjiren_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_canjiren.Checked)
            {
                cbk_mind.Enabled = true;
            }
            else {
                cbk_mind.Enabled = false;
                cbk_mind.Checked = false;
            }
        }

        private void ckb_oldman_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_oldman.Checked)
            {
                ckb_kongchao.Enabled = true;
            }
            else
            {
                ckb_kongchao.Enabled = false;
                ckb_kongchao.Checked = false;
            }
        }
    }
}
