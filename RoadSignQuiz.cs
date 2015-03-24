using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace FlagQuiz
{
   /// <summary>
   /// Summary description for FrmFlagQuiz.
   /// </summary>
   public class FrmFlagQuiz : System.Windows.Forms.Form
   {
      // GroupBox with PictureBox inside to display a flag
      private System.Windows.Forms.GroupBox fraFlagGroupBox;
      private System.Windows.Forms.PictureBox picFlag;

      // Label and ComboBox to choose a country name
      private System.Windows.Forms.Label lblChoose;
      private System.Windows.Forms.ComboBox cboOptions;

      // Label to display result
      private System.Windows.Forms.Label lblFeedback;

      // Buttons to submit an answer and move to the next flag
      private System.Windows.Forms.Button btnSubmit;
      private System.Windows.Forms.Button btnNext;

      // Label to describe how well user performed
      private System.Windows.Forms.Label lblScore;  

      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.Container components = null;

      // string array stores country names
      string[] m_strOptions = {
         "Curve", "Narrow Bridge", "No Bicycles", "No Enter",
         "No Entry", "No LeftTurn", "No U-turn", "Road Narrows", 
                              "Stop", "Stop Ahead", "traffic Light", 
                              "Yeild"};

      // boolean array tracks displayed flags
      bool[] m_blnUsed;
      
      // number of flags shown
      int m_intCount = 1;
      int m_intCorrect = 0;
      string m_strCountry; // current flag's country
      Player playerObj = new Player("Blythe", "Kirby", 28);

      public FrmFlagQuiz()
      {
         //
         // Required for Windows Form Designer support
         //
         InitializeComponent();

         //
         // TODO: Add any constructor code after InitializeComponent call
         //

      }

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      protected override void Dispose( bool disposing )
      {
         if( disposing )
         {
            if (components != null) 
            {
               components.Dispose();
            }
         }
         base.Dispose( disposing );
      }

      #region Windows Form Designer generated code
      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
            this.lblChoose = new System.Windows.Forms.Label();
            this.lblFeedback = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.fraFlagGroupBox = new System.Windows.Forms.GroupBox();
            this.picFlag = new System.Windows.Forms.PictureBox();
            this.cboOptions = new System.Windows.Forms.ComboBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.fraFlagGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFlag)).BeginInit();
            this.SuspendLayout();
            // 
            // lblChoose
            // 
            this.lblChoose.Location = new System.Drawing.Point(299, 15);
            this.lblChoose.Name = "lblChoose";
            this.lblChoose.Size = new System.Drawing.Size(194, 41);
            this.lblChoose.TabIndex = 0;
            this.lblChoose.Text = "Select sign:";
            this.lblChoose.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblChoose.Click += new System.EventHandler(this.lblChoose_Click);
            // 
            // lblFeedback
            // 
            this.lblFeedback.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFeedback.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeedback.Location = new System.Drawing.Point(299, 123);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(264, 62);
            this.lblFeedback.TabIndex = 1;
            this.lblFeedback.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(598, 15);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(194, 47);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(598, 77);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(194, 46);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Next Sign";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // fraFlagGroupBox
            // 
            this.fraFlagGroupBox.Controls.Add(this.picFlag);
            this.fraFlagGroupBox.Location = new System.Drawing.Point(18, 15);
            this.fraFlagGroupBox.Name = "fraFlagGroupBox";
            this.fraFlagGroupBox.Size = new System.Drawing.Size(246, 170);
            this.fraFlagGroupBox.TabIndex = 4;
            this.fraFlagGroupBox.TabStop = false;
            this.fraFlagGroupBox.Text = "Sign";
            // 
            // picFlag
            // 
            this.picFlag.Location = new System.Drawing.Point(35, 46);
            this.picFlag.Name = "picFlag";
            this.picFlag.Size = new System.Drawing.Size(176, 108);
            this.picFlag.TabIndex = 0;
            this.picFlag.TabStop = false;
            // 
            // cboOptions
            // 
            this.cboOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOptions.Location = new System.Drawing.Point(299, 62);
            this.cboOptions.MaxDropDownItems = 4;
            this.cboOptions.Name = "cboOptions";
            this.cboOptions.Size = new System.Drawing.Size(266, 35);
            this.cboOptions.TabIndex = 5;
            // 
            // lblScore
            // 
            this.lblScore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblScore.Location = new System.Drawing.Point(598, 139);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(194, 46);
            this.lblScore.TabIndex = 13;
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmFlagQuiz
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(11, 27);
            this.ClientSize = new System.Drawing.Size(937, 320);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.cboOptions);
            this.Controls.Add(this.fraFlagGroupBox);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblFeedback);
            this.Controls.Add(this.lblChoose);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmFlagQuiz";
            this.Text = "Sign Quiz";
            this.Load += new System.EventHandler(this.FrmFlagQuiz_Load);
            this.fraFlagGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picFlag)).EndInit();
            this.ResumeLayout(false);

      }
      #endregion

      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main() 
      {
         Application.Run( new FrmFlagQuiz() );
      }

      // handles Flag Quiz Form's Load event
      private void FrmFlagQuiz_Load(
         object sender, System.EventArgs e )
      {
         // initialize the boolean array
         m_blnUsed = new bool[ m_strOptions.GetUpperBound( 0 ) ];

         Array.Sort( m_strOptions ); // alphabetize country names

         // display country names in ComboBox
         cboOptions.DataSource = m_strOptions;

         DisplayFlag(); // display first flag in PictureBox

      } // end method FrmFlagQuiz_Load

      // return full path name of image file as a string
      string BuildPathName()
      {
         // begin with country name
         string strOutput = m_strCountry;

         // locate space character if there is one
         int intSpace = strOutput.IndexOf( " " );
         
         // remove space from country name if there is one
         if ( intSpace > 0 ) 
         {
            strOutput = strOutput.Remove( intSpace, 1 );
         }

         strOutput = strOutput.ToLower(); // make chars lowercase
         strOutput += ".png"; // add file extension

         // add path name
         strOutput = strOutput.Insert( 0,
            System.Environment.CurrentDirectory + "\\images\\" );

         return strOutput;  // return full path name

      } // end method BuildPathName

      // return an unused random number
      int GetUniqueRandomNumber()
      {
         Random objRandom = new Random();
         int intRandom;

         // generate random numbers until unused flag is found
         do
         {
            intRandom = objRandom.Next( 0, m_blnUsed.Length );
         } while ( m_blnUsed[ intRandom ] == true );

         // indicate that flag has been used
         m_blnUsed[ intRandom ] = true;

         return intRandom; // return index for new flag

      } // end method GetUniqueRandomNumber

      // display random flag in PictureBox
      void DisplayFlag()
      {
         // unique index ensures that a flag is used
         // no more than once
         int intRandom = GetUniqueRandomNumber();

         // retrieve country name from array m_strOptions
         m_strCountry = m_strOptions[ intRandom ];

         // get image's full path name
         string strPath = BuildPathName();
         picFlag.Image = Image.FromFile( strPath ); // display image

      } // end method DisplayFlag

      // handles Submit Button's Click event
      private void btnSubmit_Click(
         object sender, System.EventArgs e )
      {
         // retrieve answer from ComboBox
         string strResponse = 
            Convert.ToString( cboOptions.SelectedValue );

         // verify answer
         if ( strResponse == m_strCountry )
         {
            lblFeedback.Text = "Correct!";
            m_intCorrect++;
         }
         else
         {
            lblFeedback.Text = "Sorry, incorrect.";
         }
         playerObj.Score = m_intCorrect;
         // inform user if quiz is over
         if ( m_intCount >= 5 ) // quiz is over
         {
            lblFeedback.Text += "   Done! Score: " + playerObj.Score.ToString() + "/100";
            btnNext.Enabled = false;
            btnSubmit.Enabled = false;
            cboOptions.Enabled = false;
         }
         else // quiz is not over
         {
            btnSubmit.Enabled = false;
            btnNext.Enabled = true;
         }

      } // end method btnSubmit_Click

      // handles Next Button's Click event
      private void btnNext_Click( 
         object sender, System.EventArgs e )
      {
         DisplayFlag(); // display next flag
         lblFeedback.Text = ""; // clear output

         // change selected country to first in ComboBox
         cboOptions.SelectedIndex = 0;

         m_intCount++; // update number of flags shown

         btnSubmit.Enabled = true;
         btnNext.Enabled = false;

      }

      private void lblChoose_Click(object sender, EventArgs e)
      {

      } // end method btnNext_Click

   } // end class FrmFlagQuiz
}

/**************************************************************************
 * (C) Copyright 1992-2004 by Deitel & Associates, Inc. and               *
 * Pearson Education, Inc. All Rights Reserved.                           *
 *                                                                        *
 * DISCLAIMER: The authors and publisher of this book have used their     *
 * best efforts in preparing the book. These efforts include the          *
 * development, research, and testing of the theories and programs        *
 * to determine their effectiveness. The authors and publisher make       *
 * no warranty of any kind, expressed or implied, with regard to these    *
 * programs or to the documentation contained in these books. The authors *
 * and publisher shall not be liable in any event for incidental or       *
 * consequential damages in connection with, or arising out of, the       *
 * furnishing, performance, or use of these programs.                     *
 *************************************************************************/