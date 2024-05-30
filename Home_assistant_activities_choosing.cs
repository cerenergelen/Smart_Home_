using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smart_Home_
{
    public partial class Home_assistant_activities_choosing : Form
    {
        //-------------------------------------------------
        // Monday activities

        public static string monday6;
        public static string monday7;
        public static string monday8;
        public static string monday9;
        public static string monday10;
        public static string monday11;
        public static string monday12;
        public static string monday13;
        public static string monday14;
        public static string monday15;
        public static string monday16;
        public static string monday17;
        public static string monday18;
        public static string monday19;
        public static string monday20;
        public static string monday21;
        public static string monday22;

        // Monday activity types

        public static string monday_activity_type6;
        public static string monday_activity_type7;
        public static string monday_activity_type8;
        public static string monday_activity_type9;
        public static string monday_activity_type10;
        public static string monday_activity_type11;
        public static string monday_activity_type12;
        public static string monday_activity_type13;
        public static string monday_activity_type14;
        public static string monday_activity_type15;
        public static string monday_activity_type16;
        public static string monday_activity_type17;
        public static string monday_activity_type18;
        public static string monday_activity_type19;
        public static string monday_activity_type20;
        public static string monday_activity_type21;
        public static string monday_activity_type22;

        // Monday way of transportation

        public static string monday_transport6;
        public static string monday_transport7;
        public static string monday_transport8;
        public static string monday_transport9;
        public static string monday_transport10;
        public static string monday_transport11;
        public static string monday_transport12;
        public static string monday_transport13;
        public static string monday_transport14;
        public static string monday_transport15;
        public static string monday_transport16;
        public static string monday_transport17;
        public static string monday_transport18;
        public static string monday_transport19;
        public static string monday_transport20;
        public static string monday_transport21;
        public static string monday_transport22;


        //-------------------------------------------------
        // tuesday activities

        public static string tuesday6;
        public static string tuesday7;
        public static string tuesday8;
        public static string tuesday9;
        public static string tuesday10;
        public static string tuesday11;
        public static string tuesday12;
        public static string tuesday13;
        public static string tuesday14;
        public static string tuesday15;
        public static string tuesday16;
        public static string tuesday17;
        public static string tuesday18;
        public static string tuesday19;
        public static string tuesday20;
        public static string tuesday21;
        public static string tuesday22;

        // Tuesday activity types

        public static string tuesday_activity_type6;
        public static string tuesday_activity_type7;
        public static string tuesday_activity_type8;
        public static string tuesday_activity_type9;
        public static string tuesday_activity_type10;
        public static string tuesday_activity_type11;
        public static string tuesday_activity_type12;
        public static string tuesday_activity_type13;
        public static string tuesday_activity_type14;
        public static string tuesday_activity_type15;
        public static string tuesday_activity_type16;
        public static string tuesday_activity_type17;
        public static string tuesday_activity_type18;
        public static string tuesday_activity_type19;
        public static string tuesday_activity_type20;
        public static string tuesday_activity_type21;
        public static string tuesday_activity_type22;

        // tuesday way of transportation

        public static string tuesday_transport6;
        public static string tuesday_transport7;
        public static string tuesday_transport8;
        public static string tuesday_transport9;
        public static string tuesday_transport10;
        public static string tuesday_transport11;
        public static string tuesday_transport12;
        public static string tuesday_transport13;
        public static string tuesday_transport14;
        public static string tuesday_transport15;
        public static string tuesday_transport16;
        public static string tuesday_transport17;
        public static string tuesday_transport18;
        public static string tuesday_transport19;
        public static string tuesday_transport20;
        public static string tuesday_transport21;
        public static string tuesday_transport22;

        //-------------------------------------------------
        // wednesday activities

        public static string wednesday6;
        public static string wednesday7;
        public static string wednesday8;
        public static string wednesday9;
        public static string wednesday10;
        public static string wednesday11;
        public static string wednesday12;
        public static string wednesday13;
        public static string wednesday14;
        public static string wednesday15;
        public static string wednesday16;
        public static string wednesday17;
        public static string wednesday18;
        public static string wednesday19;
        public static string wednesday20;
        public static string wednesday21;
        public static string wednesday22;

        // wednesday activity types

        public static string wednesday_activity_type6;
        public static string wednesday_activity_type7;
        public static string wednesday_activity_type8;
        public static string wednesday_activity_type9;
        public static string wednesday_activity_type10;
        public static string wednesday_activity_type11;
        public static string wednesday_activity_type12;
        public static string wednesday_activity_type13;
        public static string wednesday_activity_type14;
        public static string wednesday_activity_type15;
        public static string wednesday_activity_type16;
        public static string wednesday_activity_type17;
        public static string wednesday_activity_type18;
        public static string wednesday_activity_type19;
        public static string wednesday_activity_type20;
        public static string wednesday_activity_type21;
        public static string wednesday_activity_type22;

        // wednesday way of transportation

        public static string wednesday_transport6;
        public static string wednesday_transport7;
        public static string wednesday_transport8;
        public static string wednesday_transport9;
        public static string wednesday_transport10;
        public static string wednesday_transport11;
        public static string wednesday_transport12;
        public static string wednesday_transport13;
        public static string wednesday_transport14;
        public static string wednesday_transport15;
        public static string wednesday_transport16;
        public static string wednesday_transport17;
        public static string wednesday_transport18;
        public static string wednesday_transport19;
        public static string wednesday_transport20;
        public static string wednesday_transport21;
        public static string wednesday_transport22;

        //-------------------------------------------------
        // thursday activities

        public static string thursday6;
        public static string thursday7;
        public static string thursday8;
        public static string thursday9;
        public static string thursday10;
        public static string thursday11;
        public static string thursday12;
        public static string thursday13;
        public static string thursday14;
        public static string thursday15;
        public static string thursday16;
        public static string thursday17;
        public static string thursday18;
        public static string thursday19;
        public static string thursday20;
        public static string thursday21;
        public static string thursday22;

        // thursday activity types

        public static string thursday_activity_type6;
        public static string thursday_activity_type7;
        public static string thursday_activity_type8;
        public static string thursday_activity_type9;
        public static string thursday_activity_type10;
        public static string thursday_activity_type11;
        public static string thursday_activity_type12;
        public static string thursday_activity_type13;
        public static string thursday_activity_type14;
        public static string thursday_activity_type15;
        public static string thursday_activity_type16;
        public static string thursday_activity_type17;
        public static string thursday_activity_type18;
        public static string thursday_activity_type19;
        public static string thursday_activity_type20;
        public static string thursday_activity_type21;
        public static string thursday_activity_type22;

        // thursday way of transportation

        public static string thursday_transport6;
        public static string thursday_transport7;
        public static string thursday_transport8;
        public static string thursday_transport9;
        public static string thursday_transport10;
        public static string thursday_transport11;
        public static string thursday_transport12;
        public static string thursday_transport13;
        public static string thursday_transport14;
        public static string thursday_transport15;
        public static string thursday_transport16;
        public static string thursday_transport17;
        public static string thursday_transport18;
        public static string thursday_transport19;
        public static string thursday_transport20;
        public static string thursday_transport21;
        public static string thursday_transport22;

        //-------------------------------------------------
        // friday activities

        public static string friday6;
        public static string friday7;
        public static string friday8;
        public static string friday9;
        public static string friday10;
        public static string friday11;
        public static string friday12;
        public static string friday13;
        public static string friday14;
        public static string friday15;
        public static string friday16;
        public static string friday17;
        public static string friday18;
        public static string friday19;
        public static string friday20;
        public static string friday21;
        public static string friday22;

        // friday activity types

        public static string friday_activity_type6;
        public static string friday_activity_type7;
        public static string friday_activity_type8;
        public static string friday_activity_type9;
        public static string friday_activity_type10;
        public static string friday_activity_type11;
        public static string friday_activity_type12;
        public static string friday_activity_type13;
        public static string friday_activity_type14;
        public static string friday_activity_type15;
        public static string friday_activity_type16;
        public static string friday_activity_type17;
        public static string friday_activity_type18;
        public static string friday_activity_type19;
        public static string friday_activity_type20;
        public static string friday_activity_type21;
        public static string friday_activity_type22;

        // friday way of transportation

        public static string friday_transport6;
        public static string friday_transport7;
        public static string friday_transport8;
        public static string friday_transport9;
        public static string friday_transport10;
        public static string friday_transport11;
        public static string friday_transport12;
        public static string friday_transport13;
        public static string friday_transport14;
        public static string friday_transport15;
        public static string friday_transport16;
        public static string friday_transport17;
        public static string friday_transport18;
        public static string friday_transport19;
        public static string friday_transport20;
        public static string friday_transport21;
        public static string friday_transport22;

        //-------------------------------------------------
        // saturday activities

        public static string saturday6;
        public static string saturday7;
        public static string saturday8;
        public static string saturday9;
        public static string saturday10;
        public static string saturday11;
        public static string saturday12;
        public static string saturday13;
        public static string saturday14;
        public static string saturday15;
        public static string saturday16;
        public static string saturday17;
        public static string saturday18;
        public static string saturday19;
        public static string saturday20;
        public static string saturday21;
        public static string saturday22;

        // saturday activity types

        public static string saturday_activity_type6;
        public static string saturday_activity_type7;
        public static string saturday_activity_type8;
        public static string saturday_activity_type9;
        public static string saturday_activity_type10;
        public static string saturday_activity_type11;
        public static string saturday_activity_type12;
        public static string saturday_activity_type13;
        public static string saturday_activity_type14;
        public static string saturday_activity_type15;
        public static string saturday_activity_type16;
        public static string saturday_activity_type17;
        public static string saturday_activity_type18;
        public static string saturday_activity_type19;
        public static string saturday_activity_type20;
        public static string saturday_activity_type21;
        public static string saturday_activity_type22;

        // saturday way of transportation

        public static string saturday_transport6;
        public static string saturday_transport7;
        public static string saturday_transport8;
        public static string saturday_transport9;
        public static string saturday_transport10;
        public static string saturday_transport11;
        public static string saturday_transport12;
        public static string saturday_transport13;
        public static string saturday_transport14;
        public static string saturday_transport15;
        public static string saturday_transport16;
        public static string saturday_transport17;
        public static string saturday_transport18;
        public static string saturday_transport19;
        public static string saturday_transport20;
        public static string saturday_transport21;
        public static string saturday_transport22;

        //-------------------------------------------------
        // sunday activities

        public static string sunday6;
        public static string sunday7;
        public static string sunday8;
        public static string sunday9;
        public static string sunday10;
        public static string sunday11;
        public static string sunday12;
        public static string sunday13;
        public static string sunday14;
        public static string sunday15;
        public static string sunday16;
        public static string sunday17;
        public static string sunday18;
        public static string sunday19;
        public static string sunday20;
        public static string sunday21;
        public static string sunday22;

        // sunday activity types

        public static string sunday_activity_type6;
        public static string sunday_activity_type7;
        public static string sunday_activity_type8;
        public static string sunday_activity_type9;
        public static string sunday_activity_type10;
        public static string sunday_activity_type11;
        public static string sunday_activity_type12;
        public static string sunday_activity_type13;
        public static string sunday_activity_type14;
        public static string sunday_activity_type15;
        public static string sunday_activity_type16;
        public static string sunday_activity_type17;
        public static string sunday_activity_type18;
        public static string sunday_activity_type19;
        public static string sunday_activity_type20;
        public static string sunday_activity_type21;
        public static string sunday_activity_type22;

        // sunday way of transportation

        public static string sunday_transport6;
        public static string sunday_transport7;
        public static string sunday_transport8;
        public static string sunday_transport9;
        public static string sunday_transport10;
        public static string sunday_transport11;
        public static string sunday_transport12;
        public static string sunday_transport13;
        public static string sunday_transport14;
        public static string sunday_transport15;
        public static string sunday_transport16;
        public static string sunday_transport17;
        public static string sunday_transport18;
        public static string sunday_transport19;
        public static string sunday_transport20;
        public static string sunday_transport21;
        public static string sunday_transport22;

        //-------------------------------------------------





        public static string day;
        public static int day_code;

        public Home_assistant_activities_choosing(string today, int dayCode)
        {

            InitializeComponent();
            day_code = dayCode;
            day = today;
        }



        private void onlineHelpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            Home_assistant_day_choosing day = new Home_assistant_day_choosing();
            day.Show();
        }

        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Nikos_assistant_activities_choosing_Load(object sender, EventArgs e)
        {
            label25.Text = day;
        }

        public string activity_type(RadioButton r1, RadioButton r2, RadioButton r3)
        {
            if (r1.Checked == true)
            {
                return r1.Text;
            }
            else if (r2.Checked == true)
            {
                return r2.Text;
            }
            else
            {
                return r3.Text;
            }
        }

        public string transport_way(RadioButton r1, RadioButton r2, RadioButton r3, RadioButton r4)
        {
            if (r1.Checked == true)
            {
                return r1.Text;
            }
            else if (r2.Checked == true)
            {
                return r2.Text;
            }
            else if (r3.Checked == true)
            {
                return r3.Text;
            }
            else
            {
                return r4.Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Το πρόγραμμα της ημέρας υποβλήθηκε με επιτυχία");
            if (day_code == 1)
            {
                Home_personal_assistant.monday_has_plan = true;

                monday6 = textBox6.Text;
                monday7 = textBox7.Text;
                monday8 = textBox8.Text;
                monday9 = textBox9.Text;
                monday10 = textBox10.Text;
                monday11 = textBox11.Text;
                monday12 = textBox12.Text;
                monday13 = textBox13.Text;
                monday14 = textBox14.Text;
                monday15 = textBox15.Text;
                monday16 = textBox16.Text;
                monday17 = textBox17.Text;
                monday18 = textBox18.Text;
                monday19 = textBox19.Text;
                monday20 = textBox20.Text;
                monday21 = textBox21.Text;
                monday22 = textBox22.Text;
                if (monday6 != "")
                {
                    // Writing the type of the activity in a variable
                    monday_activity_type6 = activity_type(radioButton1, radioButton2, radioButton3);

                    // Writing the way of transport in a variable
                    monday_transport6 = transport_way(radioButton52, radioButton53, radioButton54, radioButton55);
                }
                if (monday7 != "")
                {
                    // Writing the type of the activity in a variable
                    monday_activity_type7 = activity_type(radioButton4, radioButton5, radioButton6);

                    // Writing the way of transport in a variable
                    monday_transport7 = transport_way(radioButton56, radioButton57, radioButton58, radioButton59);
                }
                if (monday8 != "")
                {
                    // Writing the type of the activity in a variable
                    monday_activity_type8 = activity_type(radioButton7, radioButton8, radioButton9);

                    // Writing the way of transport in a variable
                    monday_transport8 = transport_way(radioButton60, radioButton61, radioButton62, radioButton63);
                }
                if (monday9 != "")
                {
                    // Writing the type of the activity in a variable
                    monday_activity_type9 = activity_type(radioButton10, radioButton11, radioButton12);

                    // Writing the way of transport in a variable
                    monday_transport9 = transport_way(radioButton64, radioButton65, radioButton66, radioButton67);
                }
                if (monday10 != "")
                {
                    // Writing the type of the activity in a variable
                    monday_activity_type10 = activity_type(radioButton13, radioButton14, radioButton15);

                    // Writing the way of transport in a variable
                    monday_transport10 = transport_way(radioButton68, radioButton69, radioButton70, radioButton71);
                }
                if (monday11 != "")
                {
                    // Writing the type of the activity in a variable
                    monday_activity_type11 = activity_type(radioButton16, radioButton17, radioButton18);

                    // Writing the way of transport in a variable
                    monday_transport11 = transport_way(radioButton72, radioButton73, radioButton74, radioButton75);
                }
                if (monday12 != "")
                {
                    // Writing the type of the activity in a variable
                    monday_activity_type12 = activity_type(radioButton19, radioButton20, radioButton21);

                    // Writing the way of transport in a variable
                    monday_transport12 = transport_way(radioButton76, radioButton77, radioButton78, radioButton79);
                }
                if (monday13 != "")
                {
                    // Writing the type of the activity in a variable
                    monday_activity_type13 = activity_type(radioButton22, radioButton23, radioButton24);

                    // Writing the way of transport in a variable
                    monday_transport13 = transport_way(radioButton80, radioButton81, radioButton82, radioButton83);
                }
                if (monday14 != "")
                {
                    // Writing the type of the activity in a variable
                    monday_activity_type14 = activity_type(radioButton25, radioButton26, radioButton27);

                    // Writing the way of transport in a variable
                    monday_transport14 = transport_way(radioButton84, radioButton85, radioButton86, radioButton87);
                }
                if (monday15 != "")
                {
                    // Writing the type of the activity in a variable
                    monday_activity_type15 = activity_type(radioButton25, radioButton26, radioButton27);

                    // Writing the way of transport in a variable
                    monday_transport15 = transport_way(radioButton88, radioButton89, radioButton90, radioButton91);
                }
                if (monday16 != "")
                {
                    // Writing the type of the activity in a variable
                    monday_activity_type16 = activity_type(radioButton28, radioButton29, radioButton30);

                    // Writing the way of transport in a variable
                    monday_transport16 = transport_way(radioButton92, radioButton93, radioButton94, radioButton95);
                }
                if (monday17 != "")
                {
                    // Writing the type of the activity in a variable
                    monday_activity_type17 = activity_type(radioButton31, radioButton32, radioButton33);

                    // Writing the way of transport in a variable
                    monday_transport17 = transport_way(radioButton96, radioButton97, radioButton98, radioButton99);
                }
                if (monday18 != "")
                {
                    // Writing the type of the activity in a variable
                    monday_activity_type18 = activity_type(radioButton34, radioButton35, radioButton36);

                    // Writing the way of transport in a variable
                    monday_transport18 = transport_way(radioButton100, radioButton101, radioButton102, radioButton103);
                }
                if (monday19 != "")
                {
                    // Writing the type of the activity in a variable
                    monday_activity_type19 = activity_type(radioButton37, radioButton38, radioButton39);

                    // Writing the way of transport in a variable
                    monday_transport19 = transport_way(radioButton104, radioButton105, radioButton106, radioButton107);
                }
                if (monday20 != "")
                {
                    // Writing the type of the activity in a variable
                    monday_activity_type20 = activity_type(radioButton40, radioButton41, radioButton42);

                    // Writing the way of transport in a variable
                    monday_transport20 = transport_way(radioButton108, radioButton109, radioButton110, radioButton111);
                }
                if (monday21 != "")
                {
                    // Writing the type of the activity in a variable
                    monday_activity_type21 = activity_type(radioButton43, radioButton44, radioButton45);

                    // Writing the way of transport in a variable
                    monday_transport21 = transport_way(radioButton112, radioButton113, radioButton114, radioButton115);
                }
                if (monday22 != "")
                {
                    // Writing the type of the activity in a variable
                    monday_activity_type22 = activity_type(radioButton45, radioButton46, radioButton47);

                    // Writing the way of transport in a variable
                    monday_transport22 = transport_way(radioButton116, radioButton117, radioButton118, radioButton119);
                }
            }
            if (day_code == 2)
            {
                Home_personal_assistant.tuesday_has_plan = true;

                tuesday6 = textBox6.Text;
                tuesday7 = textBox7.Text;
                tuesday8 = textBox8.Text;
                tuesday9 = textBox9.Text;
                tuesday10 = textBox10.Text;
                tuesday11 = textBox11.Text;
                tuesday12 = textBox12.Text;
                tuesday13 = textBox13.Text;
                tuesday14 = textBox14.Text;
                tuesday15 = textBox15.Text;
                tuesday16 = textBox16.Text;
                tuesday17 = textBox17.Text;
                tuesday18 = textBox18.Text;
                tuesday19 = textBox19.Text;
                tuesday20 = textBox20.Text;
                tuesday21 = textBox21.Text;
                tuesday22 = textBox22.Text;
                if (tuesday6 != "")
                {
                    // Writing the type of the activity in a variable
                    tuesday_activity_type6 = activity_type(radioButton1, radioButton2, radioButton3);

                    // Writing the way of transport in a variable
                    tuesday_transport6 = transport_way(radioButton52, radioButton53, radioButton54, radioButton55);
                }
                if (tuesday7 != "")
                {
                    // Writing the type of the activity in a variable
                    tuesday_activity_type7 = activity_type(radioButton4, radioButton5, radioButton6);

                    // Writing the way of transport in a variable
                    tuesday_transport7 = transport_way(radioButton56, radioButton57, radioButton58, radioButton59);
                }
                if (tuesday8 != "")
                {
                    // Writing the type of the activity in a variable
                    tuesday_activity_type8 = activity_type(radioButton7, radioButton8, radioButton9);

                    // Writing the way of transport in a variable
                    tuesday_transport8 = transport_way(radioButton60, radioButton61, radioButton62, radioButton63);
                }
                if (tuesday9 != "")
                {
                    // Writing the type of the activity in a variable
                    tuesday_activity_type9 = activity_type(radioButton10, radioButton11, radioButton12);

                    // Writing the way of transport in a variable
                    tuesday_transport9 = transport_way(radioButton64, radioButton65, radioButton66, radioButton67);
                }
                if (tuesday10 != "")
                {
                    // Writing the type of the activity in a variable
                    tuesday_activity_type10 = activity_type(radioButton13, radioButton14, radioButton15);

                    // Writing the way of transport in a variable
                    tuesday_transport10 = transport_way(radioButton68, radioButton69, radioButton70, radioButton71);
                }
                if (tuesday11 != "")
                {
                    // Writing the type of the activity in a variable
                    tuesday_activity_type11 = activity_type(radioButton16, radioButton17, radioButton18);

                    // Writing the way of transport in a variable
                    tuesday_transport11 = transport_way(radioButton72, radioButton73, radioButton74, radioButton75);
                }
                if (tuesday12 != "")
                {
                    // Writing the type of the activity in a variable
                    tuesday_activity_type12 = activity_type(radioButton19, radioButton20, radioButton21);

                    // Writing the way of transport in a variable
                    tuesday_transport12 = transport_way(radioButton76, radioButton77, radioButton78, radioButton79);
                }
                if (tuesday13 != "")
                {
                    // Writing the type of the activity in a variable
                    tuesday_activity_type13 = activity_type(radioButton22, radioButton23, radioButton24);

                    // Writing the way of transport in a variable
                    tuesday_transport13 = transport_way(radioButton80, radioButton81, radioButton82, radioButton83);
                }
                if (tuesday14 != "")
                {
                    // Writing the type of the activity in a variable
                    tuesday_activity_type14 = activity_type(radioButton25, radioButton26, radioButton27);

                    // Writing the way of transport in a variable
                    tuesday_transport14 = transport_way(radioButton84, radioButton85, radioButton86, radioButton87);
                }
                if (tuesday15 != "")
                {
                    // Writing the type of the activity in a variable
                    tuesday_activity_type15 = activity_type(radioButton25, radioButton26, radioButton27);

                    // Writing the way of transport in a variable
                    tuesday_transport15 = transport_way(radioButton88, radioButton89, radioButton90, radioButton91);
                }
                if (tuesday16 != "")
                {
                    // Writing the type of the activity in a variable
                    tuesday_activity_type16 = activity_type(radioButton28, radioButton29, radioButton30);

                    // Writing the way of transport in a variable
                    tuesday_transport16 = transport_way(radioButton92, radioButton93, radioButton94, radioButton95);
                }
                if (tuesday17 != "")
                {
                    // Writing the type of the activity in a variable
                    tuesday_activity_type17 = activity_type(radioButton31, radioButton32, radioButton33);

                    // Writing the way of transport in a variable
                    tuesday_transport17 = transport_way(radioButton96, radioButton97, radioButton98, radioButton99);
                }
                if (tuesday18 != "")
                {
                    // Writing the type of the activity in a variable
                    tuesday_activity_type18 = activity_type(radioButton34, radioButton35, radioButton36);

                    // Writing the way of transport in a variable
                    tuesday_transport18 = transport_way(radioButton100, radioButton101, radioButton102, radioButton103);
                }
                if (tuesday19 != "")
                {
                    // Writing the type of the activity in a variable
                    tuesday_activity_type19 = activity_type(radioButton37, radioButton38, radioButton39);

                    // Writing the way of transport in a variable
                    tuesday_transport19 = transport_way(radioButton104, radioButton105, radioButton106, radioButton107);
                }
                if (tuesday20 != "")
                {
                    // Writing the type of the activity in a variable
                    tuesday_activity_type20 = activity_type(radioButton40, radioButton41, radioButton42);

                    // Writing the way of transport in a variable
                    tuesday_transport20 = transport_way(radioButton108, radioButton109, radioButton110, radioButton111);
                }
                if (tuesday21 != "")
                {
                    // Writing the type of the activity in a variable
                    tuesday_activity_type21 = activity_type(radioButton43, radioButton44, radioButton45);

                    // Writing the way of transport in a variable
                    tuesday_transport21 = transport_way(radioButton112, radioButton113, radioButton114, radioButton115);
                }
                if (tuesday22 != "")
                {
                    // Writing the type of the activity in a variable
                    tuesday_activity_type22 = activity_type(radioButton45, radioButton46, radioButton47);

                    // Writing the way of transport in a variable
                    tuesday_transport22 = transport_way(radioButton116, radioButton117, radioButton118, radioButton119);
                }
            }
            if (day_code == 3)
            {
                Home_personal_assistant.wednesday_has_plan = true;

                wednesday6 = textBox6.Text;
                wednesday7 = textBox7.Text;
                wednesday8 = textBox8.Text;
                wednesday9 = textBox9.Text;
                wednesday10 = textBox10.Text;
                wednesday11 = textBox11.Text;
                wednesday12 = textBox12.Text;
                wednesday13 = textBox13.Text;
                wednesday14 = textBox14.Text;
                wednesday15 = textBox15.Text;
                wednesday16 = textBox16.Text;
                wednesday17 = textBox17.Text;
                wednesday18 = textBox18.Text;
                wednesday19 = textBox19.Text;
                wednesday20 = textBox20.Text;
                wednesday21 = textBox21.Text;
                wednesday22 = textBox22.Text;
                if (wednesday6 != "")
                {
                    // Writing the type of the activity in a variable
                    wednesday_activity_type6 = activity_type(radioButton1, radioButton2, radioButton3);

                    // Writing the way of transport in a variable
                    wednesday_transport6 = transport_way(radioButton52, radioButton53, radioButton54, radioButton55);
                }
                if (wednesday7 != "")
                {
                    // Writing the type of the activity in a variable
                    wednesday_activity_type7 = activity_type(radioButton4, radioButton5, radioButton6);

                    // Writing the way of transport in a variable
                    wednesday_transport7 = transport_way(radioButton56, radioButton57, radioButton58, radioButton59);
                }
                if (wednesday8 != "")
                {
                    // Writing the type of the activity in a variable
                    wednesday_activity_type8 = activity_type(radioButton7, radioButton8, radioButton9);

                    // Writing the way of transport in a variable
                    wednesday_transport8 = transport_way(radioButton60, radioButton61, radioButton62, radioButton63);
                }
                if (wednesday9 != "")
                {
                    // Writing the type of the activity in a variable
                    wednesday_activity_type9 = activity_type(radioButton10, radioButton11, radioButton12);

                    // Writing the way of transport in a variable
                    wednesday_transport9 = transport_way(radioButton64, radioButton65, radioButton66, radioButton67);
                }
                if (wednesday10 != "")
                {
                    // Writing the type of the activity in a variable
                    wednesday_activity_type10 = activity_type(radioButton13, radioButton14, radioButton15);

                    // Writing the way of transport in a variable
                    wednesday_transport10 = transport_way(radioButton68, radioButton69, radioButton70, radioButton71);
                }
                if (wednesday11 != "")
                {
                    // Writing the type of the activity in a variable
                    wednesday_activity_type11 = activity_type(radioButton16, radioButton17, radioButton18);

                    // Writing the way of transport in a variable
                    wednesday_transport11 = transport_way(radioButton72, radioButton73, radioButton74, radioButton75);
                }
                if (wednesday12 != "")
                {
                    // Writing the type of the activity in a variable
                    wednesday_activity_type12 = activity_type(radioButton19, radioButton20, radioButton21);

                    // Writing the way of transport in a variable
                    wednesday_transport12 = transport_way(radioButton76, radioButton77, radioButton78, radioButton79);
                }
                if (wednesday13 != "")
                {
                    // Writing the type of the activity in a variable
                    wednesday_activity_type13 = activity_type(radioButton22, radioButton23, radioButton24);

                    // Writing the way of transport in a variable
                    wednesday_transport13 = transport_way(radioButton80, radioButton81, radioButton82, radioButton83);
                }
                if (wednesday14 != "")
                {
                    // Writing the type of the activity in a variable
                    wednesday_activity_type14 = activity_type(radioButton25, radioButton26, radioButton27);

                    // Writing the way of transport in a variable
                    wednesday_transport14 = transport_way(radioButton84, radioButton85, radioButton86, radioButton87);
                }
                if (wednesday15 != "")
                {
                    // Writing the type of the activity in a variable
                    wednesday_activity_type15 = activity_type(radioButton25, radioButton26, radioButton27);

                    // Writing the way of transport in a variable
                    wednesday_transport15 = transport_way(radioButton88, radioButton89, radioButton90, radioButton91);
                }
                if (wednesday16 != "")
                {
                    // Writing the type of the activity in a variable
                    wednesday_activity_type16 = activity_type(radioButton28, radioButton29, radioButton30);

                    // Writing the way of transport in a variable
                    wednesday_transport16 = transport_way(radioButton92, radioButton93, radioButton94, radioButton95);
                }
                if (wednesday17 != "")
                {
                    // Writing the type of the activity in a variable
                    wednesday_activity_type17 = activity_type(radioButton31, radioButton32, radioButton33);

                    // Writing the way of transport in a variable
                    wednesday_transport17 = transport_way(radioButton96, radioButton97, radioButton98, radioButton99);
                }
                if (wednesday18 != "")
                {
                    // Writing the type of the activity in a variable
                    wednesday_activity_type18 = activity_type(radioButton34, radioButton35, radioButton36);

                    // Writing the way of transport in a variable
                    wednesday_transport18 = transport_way(radioButton100, radioButton101, radioButton102, radioButton103);
                }
                if (wednesday19 != "")
                {
                    // Writing the type of the activity in a variable
                    wednesday_activity_type19 = activity_type(radioButton37, radioButton38, radioButton39);

                    // Writing the way of transport in a variable
                    wednesday_transport19 = transport_way(radioButton104, radioButton105, radioButton106, radioButton107);
                }
                if (wednesday20 != "")
                {
                    // Writing the type of the activity in a variable
                    wednesday_activity_type20 = activity_type(radioButton40, radioButton41, radioButton42);

                    // Writing the way of transport in a variable
                    wednesday_transport20 = transport_way(radioButton108, radioButton109, radioButton110, radioButton111);
                }
                if (wednesday21 != "")
                {
                    // Writing the type of the activity in a variable
                    wednesday_activity_type21 = activity_type(radioButton43, radioButton44, radioButton45);

                    // Writing the way of transport in a variable
                    wednesday_transport21 = transport_way(radioButton112, radioButton113, radioButton114, radioButton115);
                }
                if (wednesday22 != "")
                {
                    // Writing the type of the activity in a variable
                    wednesday_activity_type22 = activity_type(radioButton45, radioButton46, radioButton47);

                    // Writing the way of transport in a variable
                    wednesday_transport22 = transport_way(radioButton116, radioButton117, radioButton118, radioButton119);
                }
            }
            if (day_code == 4)
            {
                Home_personal_assistant.thursday_has_plan = true;

                thursday6 = textBox6.Text;
                thursday7 = textBox7.Text;
                thursday8 = textBox8.Text;
                thursday9 = textBox9.Text;
                thursday10 = textBox10.Text;
                thursday11 = textBox11.Text;
                thursday12 = textBox12.Text;
                thursday13 = textBox13.Text;
                thursday14 = textBox14.Text;
                thursday15 = textBox15.Text;
                thursday16 = textBox16.Text;
                thursday17 = textBox17.Text;
                thursday18 = textBox18.Text;
                thursday19 = textBox19.Text;
                thursday20 = textBox20.Text;
                thursday21 = textBox21.Text;
                thursday22 = textBox22.Text;
                if (thursday6 != "")
                {
                    // Writing the type of the activity in a variable
                    thursday_activity_type6 = activity_type(radioButton1, radioButton2, radioButton3);

                    // Writing the way of transport in a variable
                    thursday_transport6 = transport_way(radioButton52, radioButton53, radioButton54, radioButton55);
                }
                if (thursday7 != "")
                {
                    // Writing the type of the activity in a variable
                    thursday_activity_type7 = activity_type(radioButton4, radioButton5, radioButton6);

                    // Writing the way of transport in a variable
                    thursday_transport7 = transport_way(radioButton56, radioButton57, radioButton58, radioButton59);
                }
                if (thursday8 != "")
                {
                    // Writing the type of the activity in a variable
                    thursday_activity_type8 = activity_type(radioButton7, radioButton8, radioButton9);

                    // Writing the way of transport in a variable
                    thursday_transport8 = transport_way(radioButton60, radioButton61, radioButton62, radioButton63);
                }
                if (thursday9 != "")
                {
                    // Writing the type of the activity in a variable
                    thursday_activity_type9 = activity_type(radioButton10, radioButton11, radioButton12);

                    // Writing the way of transport in a variable
                    thursday_transport9 = transport_way(radioButton64, radioButton65, radioButton66, radioButton67);
                }
                if (thursday10 != "")
                {
                    // Writing the type of the activity in a variable
                    thursday_activity_type10 = activity_type(radioButton13, radioButton14, radioButton15);

                    // Writing the way of transport in a variable
                    thursday_transport10 = transport_way(radioButton68, radioButton69, radioButton70, radioButton71);
                }
                if (thursday11 != "")
                {
                    // Writing the type of the activity in a variable
                    thursday_activity_type11 = activity_type(radioButton16, radioButton17, radioButton18);

                    // Writing the way of transport in a variable
                    thursday_transport11 = transport_way(radioButton72, radioButton73, radioButton74, radioButton75);
                }
                if (thursday12 != "")
                {
                    // Writing the type of the activity in a variable
                    thursday_activity_type12 = activity_type(radioButton19, radioButton20, radioButton21);

                    // Writing the way of transport in a variable
                    thursday_transport12 = transport_way(radioButton76, radioButton77, radioButton78, radioButton79);
                }
                if (thursday13 != "")
                {
                    // Writing the type of the activity in a variable
                    thursday_activity_type13 = activity_type(radioButton22, radioButton23, radioButton24);

                    // Writing the way of transport in a variable
                    thursday_transport13 = transport_way(radioButton80, radioButton81, radioButton82, radioButton83);
                }
                if (thursday14 != "")
                {
                    // Writing the type of the activity in a variable
                    thursday_activity_type14 = activity_type(radioButton25, radioButton26, radioButton27);

                    // Writing the way of transport in a variable
                    thursday_transport14 = transport_way(radioButton84, radioButton85, radioButton86, radioButton87);
                }
                if (thursday15 != "")
                {
                    // Writing the type of the activity in a variable
                    thursday_activity_type15 = activity_type(radioButton25, radioButton26, radioButton27);

                    // Writing the way of transport in a variable
                    thursday_transport15 = transport_way(radioButton88, radioButton89, radioButton90, radioButton91);
                }
                if (thursday16 != "")
                {
                    // Writing the type of the activity in a variable
                    thursday_activity_type16 = activity_type(radioButton28, radioButton29, radioButton30);

                    // Writing the way of transport in a variable
                    thursday_transport16 = transport_way(radioButton92, radioButton93, radioButton94, radioButton95);
                }
                if (thursday17 != "")
                {
                    // Writing the type of the activity in a variable
                    thursday_activity_type17 = activity_type(radioButton31, radioButton32, radioButton33);

                    // Writing the way of transport in a variable
                    thursday_transport17 = transport_way(radioButton96, radioButton97, radioButton98, radioButton99);
                }
                if (thursday18 != "")
                {
                    // Writing the type of the activity in a variable
                    thursday_activity_type18 = activity_type(radioButton34, radioButton35, radioButton36);

                    // Writing the way of transport in a variable
                    thursday_transport18 = transport_way(radioButton100, radioButton101, radioButton102, radioButton103);
                }
                if (thursday19 != "")
                {
                    // Writing the type of the activity in a variable
                    thursday_activity_type19 = activity_type(radioButton37, radioButton38, radioButton39);

                    // Writing the way of transport in a variable
                    thursday_transport19 = transport_way(radioButton104, radioButton105, radioButton106, radioButton107);
                }
                if (thursday20 != "")
                {
                    // Writing the type of the activity in a variable
                    thursday_activity_type20 = activity_type(radioButton40, radioButton41, radioButton42);

                    // Writing the way of transport in a variable
                    thursday_transport20 = transport_way(radioButton108, radioButton109, radioButton110, radioButton111);
                }
                if (thursday21 != "")
                {
                    // Writing the type of the activity in a variable
                    thursday_activity_type21 = activity_type(radioButton43, radioButton44, radioButton45);

                    // Writing the way of transport in a variable
                    thursday_transport21 = transport_way(radioButton112, radioButton113, radioButton114, radioButton115);
                }
                if (thursday22 != "")
                {
                    // Writing the type of the activity in a variable
                    thursday_activity_type22 = activity_type(radioButton45, radioButton46, radioButton47);

                    // Writing the way of transport in a variable
                    thursday_transport22 = transport_way(radioButton116, radioButton117, radioButton118, radioButton119);
                }
            }
            if (day_code == 5)
            {
                Home_personal_assistant.friday_has_plan = true;

                friday6 = textBox6.Text;
                friday7 = textBox7.Text;
                friday8 = textBox8.Text;
                friday9 = textBox9.Text;
                friday10 = textBox10.Text;
                friday11 = textBox11.Text;
                friday12 = textBox12.Text;
                friday13 = textBox13.Text;
                friday14 = textBox14.Text;
                friday15 = textBox15.Text;
                friday16 = textBox16.Text;
                friday17 = textBox17.Text;
                friday18 = textBox18.Text;
                friday19 = textBox19.Text;
                friday20 = textBox20.Text;
                friday21 = textBox21.Text;
                friday22 = textBox22.Text;
                if (friday6 != "")
                {
                    // Writing the type of the activity in a variable
                    friday_activity_type6 = activity_type(radioButton1, radioButton2, radioButton3);

                    // Writing the way of transport in a variable
                    friday_transport6 = transport_way(radioButton52, radioButton53, radioButton54, radioButton55);
                }
                if (friday7 != "")
                {
                    // Writing the type of the activity in a variable
                    friday_activity_type7 = activity_type(radioButton4, radioButton5, radioButton6);

                    // Writing the way of transport in a variable
                    friday_transport7 = transport_way(radioButton56, radioButton57, radioButton58, radioButton59);
                }
                if (friday8 != "")
                {
                    // Writing the type of the activity in a variable
                    friday_activity_type8 = activity_type(radioButton7, radioButton8, radioButton9);

                    // Writing the way of transport in a variable
                    friday_transport8 = transport_way(radioButton60, radioButton61, radioButton62, radioButton63);
                }
                if (friday9 != "")
                {
                    // Writing the type of the activity in a variable
                    friday_activity_type9 = activity_type(radioButton10, radioButton11, radioButton12);

                    // Writing the way of transport in a variable
                    friday_transport9 = transport_way(radioButton64, radioButton65, radioButton66, radioButton67);
                }
                if (friday10 != "")
                {
                    // Writing the type of the activity in a variable
                    friday_activity_type10 = activity_type(radioButton13, radioButton14, radioButton15);

                    // Writing the way of transport in a variable
                    friday_transport10 = transport_way(radioButton68, radioButton69, radioButton70, radioButton71);
                }
                if (friday11 != "")
                {
                    // Writing the type of the activity in a variable
                    friday_activity_type11 = activity_type(radioButton16, radioButton17, radioButton18);

                    // Writing the way of transport in a variable
                    friday_transport11 = transport_way(radioButton72, radioButton73, radioButton74, radioButton75);
                }
                if (friday12 != "")
                {
                    // Writing the type of the activity in a variable
                    friday_activity_type12 = activity_type(radioButton19, radioButton20, radioButton21);

                    // Writing the way of transport in a variable
                    friday_transport12 = transport_way(radioButton76, radioButton77, radioButton78, radioButton79);
                }
                if (friday13 != "")
                {
                    // Writing the type of the activity in a variable
                    friday_activity_type13 = activity_type(radioButton22, radioButton23, radioButton24);

                    // Writing the way of transport in a variable
                    friday_transport13 = transport_way(radioButton80, radioButton81, radioButton82, radioButton83);
                }
                if (friday14 != "")
                {
                    // Writing the type of the activity in a variable
                    friday_activity_type14 = activity_type(radioButton25, radioButton26, radioButton27);

                    // Writing the way of transport in a variable
                    friday_transport14 = transport_way(radioButton84, radioButton85, radioButton86, radioButton87);
                }
                if (friday15 != "")
                {
                    // Writing the type of the activity in a variable
                    friday_activity_type15 = activity_type(radioButton25, radioButton26, radioButton27);

                    // Writing the way of transport in a variable
                    friday_transport15 = transport_way(radioButton88, radioButton89, radioButton90, radioButton91);
                }
                if (friday16 != "")
                {
                    // Writing the type of the activity in a variable
                    friday_activity_type16 = activity_type(radioButton28, radioButton29, radioButton30);

                    // Writing the way of transport in a variable
                    friday_transport16 = transport_way(radioButton92, radioButton93, radioButton94, radioButton95);
                }
                if (friday17 != "")
                {
                    // Writing the type of the activity in a variable
                    friday_activity_type17 = activity_type(radioButton31, radioButton32, radioButton33);

                    // Writing the way of transport in a variable
                    friday_transport17 = transport_way(radioButton96, radioButton97, radioButton98, radioButton99);
                }
                if (friday18 != "")
                {
                    // Writing the type of the activity in a variable
                    friday_activity_type18 = activity_type(radioButton34, radioButton35, radioButton36);

                    // Writing the way of transport in a variable
                    friday_transport18 = transport_way(radioButton100, radioButton101, radioButton102, radioButton103);
                }
                if (friday19 != "")
                {
                    // Writing the type of the activity in a variable
                    friday_activity_type19 = activity_type(radioButton37, radioButton38, radioButton39);

                    // Writing the way of transport in a variable
                    friday_transport19 = transport_way(radioButton104, radioButton105, radioButton106, radioButton107);
                }
                if (friday20 != "")
                {
                    // Writing the type of the activity in a variable
                    friday_activity_type20 = activity_type(radioButton40, radioButton41, radioButton42);

                    // Writing the way of transport in a variable
                    friday_transport20 = transport_way(radioButton108, radioButton109, radioButton110, radioButton111);
                }
                if (friday21 != "")
                {
                    // Writing the type of the activity in a variable
                    friday_activity_type21 = activity_type(radioButton43, radioButton44, radioButton45);

                    // Writing the way of transport in a variable
                    friday_transport21 = transport_way(radioButton112, radioButton113, radioButton114, radioButton115);
                }
                if (friday22 != "")
                {
                    // Writing the type of the activity in a variable
                    friday_activity_type22 = activity_type(radioButton45, radioButton46, radioButton47);

                    // Writing the way of transport in a variable
                    friday_transport22 = transport_way(radioButton116, radioButton117, radioButton118, radioButton119);
                }
            }
            if (day_code == 6)
            {
                Home_personal_assistant.saturday_has_plan = true;

                saturday6 = textBox6.Text;
                saturday7 = textBox7.Text;
                saturday8 = textBox8.Text;
                saturday9 = textBox9.Text;
                saturday10 = textBox10.Text;
                saturday11 = textBox11.Text;
                saturday12 = textBox12.Text;
                saturday13 = textBox13.Text;
                saturday14 = textBox14.Text;
                saturday15 = textBox15.Text;
                saturday16 = textBox16.Text;
                saturday17 = textBox17.Text;
                saturday18 = textBox18.Text;
                saturday19 = textBox19.Text;
                saturday20 = textBox20.Text;
                saturday21 = textBox21.Text;
                saturday22 = textBox22.Text;
                if (saturday6 != "")
                {
                    // Writing the type of the activity in a variable
                    saturday_activity_type6 = activity_type(radioButton1, radioButton2, radioButton3);

                    // Writing the way of transport in a variable
                    saturday_transport6 = transport_way(radioButton52, radioButton53, radioButton54, radioButton55);
                }
                if (saturday7 != "")
                {
                    // Writing the type of the activity in a variable
                    saturday_activity_type7 = activity_type(radioButton4, radioButton5, radioButton6);

                    // Writing the way of transport in a variable
                    saturday_transport7 = transport_way(radioButton56, radioButton57, radioButton58, radioButton59);
                }
                if (saturday8 != "")
                {
                    // Writing the type of the activity in a variable
                    saturday_activity_type8 = activity_type(radioButton7, radioButton8, radioButton9);

                    // Writing the way of transport in a variable
                    saturday_transport8 = transport_way(radioButton60, radioButton61, radioButton62, radioButton63);
                }
                if (saturday9 != "")
                {
                    // Writing the type of the activity in a variable
                    saturday_activity_type9 = activity_type(radioButton10, radioButton11, radioButton12);

                    // Writing the way of transport in a variable
                    saturday_transport9 = transport_way(radioButton64, radioButton65, radioButton66, radioButton67);
                }
                if (saturday10 != "")
                {
                    // Writing the type of the activity in a variable
                    saturday_activity_type10 = activity_type(radioButton13, radioButton14, radioButton15);

                    // Writing the way of transport in a variable
                    saturday_transport10 = transport_way(radioButton68, radioButton69, radioButton70, radioButton71);
                }
                if (saturday11 != "")
                {
                    // Writing the type of the activity in a variable
                    saturday_activity_type11 = activity_type(radioButton16, radioButton17, radioButton18);

                    // Writing the way of transport in a variable
                    saturday_transport11 = transport_way(radioButton72, radioButton73, radioButton74, radioButton75);
                }
                if (saturday12 != "")
                {
                    // Writing the type of the activity in a variable
                    saturday_activity_type12 = activity_type(radioButton19, radioButton20, radioButton21);

                    // Writing the way of transport in a variable
                    saturday_transport12 = transport_way(radioButton76, radioButton77, radioButton78, radioButton79);
                }
                if (saturday13 != "")
                {
                    // Writing the type of the activity in a variable
                    saturday_activity_type13 = activity_type(radioButton22, radioButton23, radioButton24);

                    // Writing the way of transport in a variable
                    saturday_transport13 = transport_way(radioButton80, radioButton81, radioButton82, radioButton83);
                }
                if (saturday14 != "")
                {
                    // Writing the type of the activity in a variable
                    saturday_activity_type14 = activity_type(radioButton25, radioButton26, radioButton27);

                    // Writing the way of transport in a variable
                    saturday_transport14 = transport_way(radioButton84, radioButton85, radioButton86, radioButton87);
                }
                if (saturday15 != "")
                {
                    // Writing the type of the activity in a variable
                    saturday_activity_type15 = activity_type(radioButton25, radioButton26, radioButton27);

                    // Writing the way of transport in a variable
                    saturday_transport15 = transport_way(radioButton88, radioButton89, radioButton90, radioButton91);
                }
                if (saturday16 != "")
                {
                    // Writing the type of the activity in a variable
                    saturday_activity_type16 = activity_type(radioButton28, radioButton29, radioButton30);

                    // Writing the way of transport in a variable
                    saturday_transport16 = transport_way(radioButton92, radioButton93, radioButton94, radioButton95);
                }
                if (saturday17 != "")
                {
                    // Writing the type of the activity in a variable
                    saturday_activity_type17 = activity_type(radioButton31, radioButton32, radioButton33);

                    // Writing the way of transport in a variable
                    saturday_transport17 = transport_way(radioButton96, radioButton97, radioButton98, radioButton99);
                }
                if (saturday18 != "")
                {
                    // Writing the type of the activity in a variable
                    saturday_activity_type18 = activity_type(radioButton34, radioButton35, radioButton36);

                    // Writing the way of transport in a variable
                    saturday_transport18 = transport_way(radioButton100, radioButton101, radioButton102, radioButton103);
                }
                if (saturday19 != "")
                {
                    // Writing the type of the activity in a variable
                    saturday_activity_type19 = activity_type(radioButton37, radioButton38, radioButton39);

                    // Writing the way of transport in a variable
                    saturday_transport19 = transport_way(radioButton104, radioButton105, radioButton106, radioButton107);
                }
                if (saturday20 != "")
                {
                    // Writing the type of the activity in a variable
                    saturday_activity_type20 = activity_type(radioButton40, radioButton41, radioButton42);

                    // Writing the way of transport in a variable
                    saturday_transport20 = transport_way(radioButton108, radioButton109, radioButton110, radioButton111);
                }
                if (saturday21 != "")
                {
                    // Writing the type of the activity in a variable
                    saturday_activity_type21 = activity_type(radioButton43, radioButton44, radioButton45);

                    // Writing the way of transport in a variable
                    saturday_transport21 = transport_way(radioButton112, radioButton113, radioButton114, radioButton115);
                }
                if (saturday22 != "")
                {
                    // Writing the type of the activity in a variable
                    saturday_activity_type22 = activity_type(radioButton45, radioButton46, radioButton47);

                    // Writing the way of transport in a variable
                    saturday_transport22 = transport_way(radioButton116, radioButton117, radioButton118, radioButton119);
                }
            }
            if (day_code == 7)
            {
                Home_personal_assistant.sunday_has_plan = true;

                sunday6 = textBox6.Text;
                sunday7 = textBox7.Text;
                sunday8 = textBox8.Text;
                sunday9 = textBox9.Text;
                sunday10 = textBox10.Text;
                sunday11 = textBox11.Text;
                sunday12 = textBox12.Text;
                sunday13 = textBox13.Text;
                sunday14 = textBox14.Text;
                sunday15 = textBox15.Text;
                sunday16 = textBox16.Text;
                sunday17 = textBox17.Text;
                sunday18 = textBox18.Text;
                sunday19 = textBox19.Text;
                sunday20 = textBox20.Text;
                sunday21 = textBox21.Text;
                sunday22 = textBox22.Text;
                if (sunday6 != "")
                {
                    // Writing the type of the activity in a variable
                    sunday_activity_type6 = activity_type(radioButton1, radioButton2, radioButton3);

                    // Writing the way of transport in a variable
                    sunday_transport6 = transport_way(radioButton52, radioButton53, radioButton54, radioButton55);
                }
                if (sunday7 != "")
                {
                    // Writing the type of the activity in a variable
                    sunday_activity_type7 = activity_type(radioButton4, radioButton5, radioButton6);

                    // Writing the way of transport in a variable
                    sunday_transport7 = transport_way(radioButton56, radioButton57, radioButton58, radioButton59);
                }
                if (sunday8 != "")
                {
                    // Writing the type of the activity in a variable
                    sunday_activity_type8 = activity_type(radioButton7, radioButton8, radioButton9);

                    // Writing the way of transport in a variable
                    sunday_transport8 = transport_way(radioButton60, radioButton61, radioButton62, radioButton63);
                }
                if (sunday9 != "")
                {
                    // Writing the type of the activity in a variable
                    sunday_activity_type9 = activity_type(radioButton10, radioButton11, radioButton12);

                    // Writing the way of transport in a variable
                    sunday_transport9 = transport_way(radioButton64, radioButton65, radioButton66, radioButton67);
                }
                if (sunday10 != "")
                {
                    // Writing the type of the activity in a variable
                    sunday_activity_type10 = activity_type(radioButton13, radioButton14, radioButton15);

                    // Writing the way of transport in a variable
                    sunday_transport10 = transport_way(radioButton68, radioButton69, radioButton70, radioButton71);
                }
                if (sunday11 != "")
                {
                    // Writing the type of the activity in a variable
                    sunday_activity_type11 = activity_type(radioButton16, radioButton17, radioButton18);

                    // Writing the way of transport in a variable
                    sunday_transport11 = transport_way(radioButton72, radioButton73, radioButton74, radioButton75);
                }
                if (sunday12 != "")
                {
                    // Writing the type of the activity in a variable
                    sunday_activity_type12 = activity_type(radioButton19, radioButton20, radioButton21);

                    // Writing the way of transport in a variable
                    sunday_transport12 = transport_way(radioButton76, radioButton77, radioButton78, radioButton79);
                }
                if (sunday13 != "")
                {
                    // Writing the type of the activity in a variable
                    sunday_activity_type13 = activity_type(radioButton22, radioButton23, radioButton24);

                    // Writing the way of transport in a variable
                    sunday_transport13 = transport_way(radioButton80, radioButton81, radioButton82, radioButton83);
                }
                if (sunday14 != "")
                {
                    // Writing the type of the activity in a variable
                    sunday_activity_type14 = activity_type(radioButton25, radioButton26, radioButton27);

                    // Writing the way of transport in a variable
                    sunday_transport14 = transport_way(radioButton84, radioButton85, radioButton86, radioButton87);
                }
                if (sunday15 != "")
                {
                    // Writing the type of the activity in a variable
                    sunday_activity_type15 = activity_type(radioButton25, radioButton26, radioButton27);

                    // Writing the way of transport in a variable
                    sunday_transport15 = transport_way(radioButton88, radioButton89, radioButton90, radioButton91);
                }
                if (sunday16 != "")
                {
                    // Writing the type of the activity in a variable
                    sunday_activity_type16 = activity_type(radioButton28, radioButton29, radioButton30);

                    // Writing the way of transport in a variable
                    sunday_transport16 = transport_way(radioButton92, radioButton93, radioButton94, radioButton95);
                }
                if (sunday17 != "")
                {
                    // Writing the type of the activity in a variable
                    sunday_activity_type17 = activity_type(radioButton31, radioButton32, radioButton33);

                    // Writing the way of transport in a variable
                    sunday_transport17 = transport_way(radioButton96, radioButton97, radioButton98, radioButton99);
                }
                if (sunday18 != "")
                {
                    // Writing the type of the activity in a variable
                    sunday_activity_type18 = activity_type(radioButton34, radioButton35, radioButton36);

                    // Writing the way of transport in a variable
                    sunday_transport18 = transport_way(radioButton100, radioButton101, radioButton102, radioButton103);
                }
                if (sunday19 != "")
                {
                    // Writing the type of the activity in a variable
                    sunday_activity_type19 = activity_type(radioButton37, radioButton38, radioButton39);

                    // Writing the way of transport in a variable
                    sunday_transport19 = transport_way(radioButton104, radioButton105, radioButton106, radioButton107);
                }
                if (sunday20 != "")
                {
                    // Writing the type of the activity in a variable
                    sunday_activity_type20 = activity_type(radioButton40, radioButton41, radioButton42);

                    // Writing the way of transport in a variable
                    sunday_transport20 = transport_way(radioButton108, radioButton109, radioButton110, radioButton111);
                }
                if (sunday21 != "")
                {
                    // Writing the type of the activity in a variable
                    sunday_activity_type21 = activity_type(radioButton43, radioButton44, radioButton45);

                    // Writing the way of transport in a variable
                    sunday_transport21 = transport_way(radioButton112, radioButton113, radioButton114, radioButton115);
                }
                if (sunday22 != "")
                {
                    // Writing the type of the activity in a variable
                    sunday_activity_type22 = activity_type(radioButton45, radioButton46, radioButton47);

                    // Writing the way of transport in a variable
                    sunday_transport22 = transport_way(radioButton116, radioButton117, radioButton118, radioButton119);
                }
            }


            this.Close();
            Home_personal_assistant assist = new Home_personal_assistant();
            assist.Show();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            richTextBox1.Visible = true;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            richTextBox1.Visible = false;
        }

        
        private void Nikos_assistant_activities_choosing_Load_1(object sender, EventArgs e)
        {

        }
    }
}
