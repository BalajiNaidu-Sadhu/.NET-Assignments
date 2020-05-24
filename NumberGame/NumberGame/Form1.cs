using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace NumberGame
{
    public partial class Form1 : Form
    {
        TableLayoutPanel dynamicTableLayoutPanel;
        public List<GameBoard> listGames = new List<GameBoard>();
        public GameBoard gameBoard;
        public GameBoard currentGame;
        public int currentGameIndex;
        DifficultyLevel difficultyLevel;
        private DateTime _startTime = DateTime.MinValue;
        private TimeSpan _currentElapsedTime = TimeSpan.Zero;
        private TimeSpan _totalElapsedTime = TimeSpan.Zero;
        private bool _timerRunning = false;
        int ValidateCount,solvedCount = 0;
        int[,] validateGrid;

        [DllImport("user32.dll")]
        static extern bool HideCaret(System.IntPtr hWnd);
        public Form1()
        {
            InitializeComponent();
            cmbDifficulty.SelectedIndex = 0;

            DirectoryInfo directoryInfo = new DirectoryInfo(@"..\..\datadirectory\");
            int index = 0;
            foreach (DirectoryInfo d in directoryInfo.GetDirectories())
            {
                int length = GetLength(d.Name);
                foreach (FileInfo f in d.GetFiles())
                {
                    gameBoard = new GameBoard
                    {
                        GameLevel = GetLevel(d.Name),
                        DisplayBoard = new int[length + 2, length + 2],
                        PlayerBoard = new int[length + 2, length + 2],
                        AnswerBoard = new int[length + 2, length + 2],
                        GridLength = length,
                        GameIndex = index
                    };
                    index++;
                    string[] lines = File.ReadAllLines(f.FullName);


                    for (int i = 0; i <= length * 2; i++)
                    {
                        char[] blocks = lines[i].ToCharArray();
                        if (lines[i].Length == 0)
                            continue;
                        for (int j = 0; j < length; j++)
                        {
                            if (i < length)
                            {
                                gameBoard.DisplayBoard[i, j] = Convert.ToInt16(Convert.ToString(blocks[j]));
                                gameBoard.PlayerBoard[i, j] = Convert.ToInt16(Convert.ToString(blocks[j]));
                            }
                            else if (i > length)
                            {
                                gameBoard.AnswerBoard[i-(length+1), j] = Convert.ToInt16(Convert.ToString(blocks[j])); ;
                            }
                        }
                    }
                    //gameBoard.PlayerBoard = gameBoard.DisplayBoard;//.CopyTo(;
                    for (int i = 0; i < length; i++)
                    {
                        int columnCount = 0;
                        int rowCount = 0;
                        for (int j = 0; j < length; j++)
                        {
                            columnCount += gameBoard.AnswerBoard[j, i];
                            rowCount += gameBoard.AnswerBoard[i, j];
                        }
                        gameBoard.DisplayBoard[length + 1, i] = columnCount;
                        gameBoard.DisplayBoard[i, length + 1] = rowCount;
                        gameBoard.PlayerBoard[length + 1, i] = columnCount;
                        gameBoard.PlayerBoard[i, length + 1] = rowCount;
                    }
                    fillDiagnolDesiredSum(gameBoard);
                    listGames.Add(gameBoard);
                }
            }
        }

        private int GetLength(string name)
        {
            switch (name)
            {
                case "easy": return 3;
                case "medium": return 5;
                case "hard": return 7;
                default: return 3;
            }
        }

        private DifficultyLevel GetLevel(string name)
        {
            switch (name)
            {
                case "easy": return DifficultyLevel.easy;
                case "medium": return DifficultyLevel.medium;
                case "hard": return DifficultyLevel.hard;
                default: return DifficultyLevel.easy;
            }
        }

        private void BtnNewGame_Click(object sender, EventArgs e)
        {
            //dynamicTableLayoutPanel.Enabled = true;
            resultPane.Visible = false;
            int selectedLevel = cmbDifficulty.SelectedIndex;
            //difficultyLevel = DifficultyLevel.none;
            if (selectedLevel<1)
            {
                MessageBox.Show("Please Select Difficulty Level","Error!!!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            int length;
            switch (selectedLevel)
            {
                case 1: difficultyLevel = DifficultyLevel.easy; length = 3; break;
                case 2: difficultyLevel = DifficultyLevel.medium; length = 5; break;
                case 3: difficultyLevel = DifficultyLevel.hard; length = 7; break;
                default: difficultyLevel = DifficultyLevel.none; length = 3; break;
            }
            if(difficultyLevel != DifficultyLevel.none)
            {
                PickGame(difficultyLevel);
                CalculateDesiredSum();
                GenerateTableLayout(length);
                btnStart.Enabled = true;
                btnHelp.Enabled = false;
            }
            _currentElapsedTime = (currentGame.GameStatus == GameStatus.InProgress) ? currentGame.TimeSpan : TimeSpan.Zero;
            _totalElapsedTime = (currentGame.GameStatus == GameStatus.InProgress) ? currentGame.TimeSpan: TimeSpan.Zero;
            grpTimer.Visible = false;
        }

        private void GenerateTableLayout(int length)
        {
            int actLength = length+1;
            length = length + 3;
            //int length = 10;
            //TableLayoutPanel dynamicTableLayoutPanel = newTableLayoutPanel();

            //tableLayoutPanel1.Visible = false;
            dynamicTableLayoutPanel = new TableLayoutPanel();
            //dynamicTableLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            dynamicTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            dynamicTableLayoutPanel.Name = "TableLayoutPanel1";
            dynamicTableLayoutPanel.Size = new System.Drawing.Size(400, 400);
            //dynamicTableLayoutPanel.BackColor = Color.LightBlue;
            // Add rows and columns  
            dynamicTableLayoutPanel.ColumnCount = length;
            dynamicTableLayoutPanel.RowCount = length;
            dynamicTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30F));
            //dynamicTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            //dynamicTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            //dynamicTableLayoutPanel.RowStyles.Add(new  RowStyle(SizeType.Absolute, 52F));
            dynamicTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            //dynamicTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
           // dynamicTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
           // dynamicTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            TextBox textBox1 = new TextBox();
            Label label = new Label();
            //Top Diagnol

            dynamicTableLayoutPanel.Controls.Add(new Label
            {
                Name = "gridvalue_0_" + (currentGame.GridLength + 2).ToString(),
                Text = "",
                Font = new Font(label.Font, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
                Size = new Size(30, 30),
            }, currentGame.GridLength + 2, 0);

            dynamicTableLayoutPanel.Controls.Add(new Label
            {
                Name = "gridvalue_0_" + (currentGame.GridLength + 1).ToString(),
                Text = "",
                Font = new Font(label.Font, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
                Size = new Size(30, 30),
            }, currentGame.GridLength + 1, 0);

            for (int i=1;i< length;i++)
            {
                for (int j = 1; j < length; j++)
                {
                    var text = currentGame.GameStatus == GameStatus.InProgress ? currentGame.PlayerBoard[i - 1, j - 1].ToString() : currentGame.DisplayBoard[i - 1, j - 1].ToString();
                    bool isIndexField = currentGame.DisplayBoard[i - 1, j - 1].ToString() == "0" ? false : true;
                    if (i == currentGame.GridLength+1 || j== currentGame.GridLength+1)
                    {
                        label = new Label();
                        label.Name = "gridvalue" + i.ToString() + j.ToString();
                        label.Text = text;

                        label.Font = new Font(label.Font, FontStyle.Bold);
                        dynamicTableLayoutPanel.Controls.Add(new Label
                        {
                        Name = "gridvalue_" + i.ToString() + "_" + j.ToString(),
                        Text = text,
                        Font = new Font(label.Font, FontStyle.Bold),
                            TextAlign = ContentAlignment.MiddleCenter,
                            Size = new Size(30, 30),
                        }, j, i);
                    }
                    else
                    {
                        //textBox1.Name = "gridvalue_" + i.ToString() +"_"+ j.ToString();
                        //textBox1.Text = currentGame.DisplayBoard[i - 1, j - 1].ToString();
                        if (i > actLength && j >= actLength)
                            continue;
                        dynamicTableLayoutPanel.Controls.Add(new TextBox
                        {
                            Text = text == "0" ? "" : text,
                            Name = "gridvalue_" + i.ToString() + "_" + j.ToString(),
                            Size = new Size(30, 30),
                            UseWaitCursor = false,
                            TextAlign = HorizontalAlignment.Center,
                            PasswordChar = '?',
                            MaxLength = 1,
                            Enabled = (text == "0" || !isIndexField) && i!=actLength && j!=actLength  ? true : false,
                            Cursor = Cursors.Arrow,
                            Font = text == "0" ? Font : new Font(label.Font, FontStyle.Bold) ,
                            

                        }, j, i);
                    }
                }
            }
            // Add child controls to TableLayoutPanel and specify rows and column  
            //dynamicTableLayoutPanel.Controls.Add(textBox1, 3, 3);
            if (currentGame.GameStatus == GameStatus.InProgress)
                preFillUserSum();
            foreach (TextBox txt in dynamicTableLayoutPanel.Controls.OfType<TextBox>())
            {
                if (txt.Enabled)
                {
                    txt.TextChanged += Txt_TextChanged;
                    txt.GotFocus += Txt_GotFocus;
                    txt.KeyPress += Txt_KeyPress;
                }
            }
            PlayGround.Controls.Clear();
            PlayGround.Controls.Add(dynamicTableLayoutPanel);
        }

        private void Txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            TextBox textBox = sender as TextBox;
            int num = Convert.ToInt32(e.KeyChar);
            if (num >= 49 && num <= 57)
                textBox.Text = e.KeyChar.ToString();
            else
                e.Handled = !char.IsDigit(e.KeyChar);
        }

        private void Txt_GotFocus(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            textBox.SelectionLength = 0;
            HideCaret(textBox.Handle);
        }

        private void Txt_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text == string.Empty)
                return;
            string[] idParts = textBox.Name.Split('_');
            int row = Convert.ToInt32(idParts[1]);
            int column = Convert.ToInt32(idParts[2]);
            int rowSum = 0,colSum=0;
            bool rowFilled = true, columnFilled = true;
            currentGame.PlayerBoard[row - 1, column - 1] = Convert.ToInt32(textBox.Text);
            textBox.ForeColor = Color.Black;
            for(int i=1;i<= currentGame.GridLength;i++)
            {
                TextBox txtRow = dynamicTableLayoutPanel.Controls.OfType<TextBox>().Where(t => t.Name.Equals("gridvalue_" + row + "_" + i)).FirstOrDefault() as TextBox;
                rowSum += txtRow.Text == String.Empty ? 0 : Convert.ToInt32(txtRow.Text);
                rowFilled = txtRow.Text == String.Empty ? false : rowFilled;
                TextBox txtColumn = dynamicTableLayoutPanel.Controls.OfType<TextBox>().Where(t => t.Name.Equals("gridvalue_" + i + "_" + column)).FirstOrDefault() as TextBox;
                colSum += txtColumn.Text == String.Empty ? 0 : Convert.ToInt32(txtColumn.Text);
                columnFilled = txtColumn.Text == String.Empty ? false : columnFilled;
            }
            Label txtUserSum_Row = dynamicTableLayoutPanel.Controls.OfType<Label>().Where(t => t.Name.Equals("gridvalue_" + row + "_" + (currentGame.GridLength+1))).FirstOrDefault() as Label;
            txtUserSum_Row.Text = rowSum.ToString();
            Label txtUserSum_Column = dynamicTableLayoutPanel.Controls.OfType<Label>().Where(t => t.Name.Equals("gridvalue_" + (currentGame.GridLength + 1)  + "_" + column)).FirstOrDefault() as Label;
            txtUserSum_Column.Text = colSum.ToString();

            TextBox txtDesiredSum_Row = dynamicTableLayoutPanel.Controls.OfType<TextBox>().Where(t => t.Name.Equals("gridvalue_" + row + "_" + (currentGame.GridLength + 2))).FirstOrDefault() as TextBox;
            TextBox txtDesiredSum_Column = dynamicTableLayoutPanel.Controls.OfType<TextBox>().Where(t => t.Name.Equals("gridvalue_" + (currentGame.GridLength + 2) + "_" + column)).FirstOrDefault() as TextBox;
            currentGame.PlayerBoard[currentGame.GridLength,column-1  ] = Convert.ToInt32(txtUserSum_Column.Text);
            currentGame.PlayerBoard[row-1, currentGame.GridLength] = Convert.ToInt32(txtUserSum_Row.Text);
            if (txtDesiredSum_Column.Text==txtUserSum_Column.Text && columnFilled)
            {
                txtUserSum_Column.ForeColor = Color.Green;
                validateGrid[column-1, 1] = 1;
                solvedCount++;
            }
            else if(columnFilled)
            {
                txtUserSum_Column.ForeColor = Color.Red;
                validateGrid[column-1, 1] = 0;
                solvedCount = solvedCount > 0 ? solvedCount-1 : solvedCount;
            }
            else
            {
                validateGrid[column-1, 1] = 0;
                txtUserSum_Column.ForeColor = Color.Black;
                //solvedCount = solvedCount > 0 ? solvedCount - 1 : solvedCount;
            }
            if (txtDesiredSum_Row.Text == txtUserSum_Row.Text && rowFilled)
            {
                txtUserSum_Row.ForeColor = Color.Green;
                validateGrid[row-1, 0] = 1;
                solvedCount++;
            }
            else if (rowFilled)
            {
                validateGrid[row-1, 0] = 0;
                txtUserSum_Row.ForeColor = Color.Red;
                solvedCount = solvedCount > 0 ? solvedCount - 1 : solvedCount;
            }
            else
            {
                txtUserSum_Row.ForeColor = Color.Black;
                validateGrid[row-1, 0] = 0;
                //solvedCount = solvedCount > 0 ? solvedCount - 1 : solvedCount;
            }
            if(row==column || (row+column+2) == currentGame.GridLength+3)
            {
                RefreshDiagnols();
            }
            if (IsLevelCompleted())
            {
                _timer.Stop();
                _timerRunning = false;
                btnStart.Text = "Start";
                btnStart.Enabled = false;
                btnHelp.Enabled = false;
                btnNewGame.Enabled = true;
                currentGame.TimeSpan = _currentElapsedTime;
                currentGame.GameStatus = GameStatus.Completed;
                if((currentGame.BestTimeSpan == TimeSpan.Zero || currentGame.TimeSpan < currentGame.BestTimeSpan) && !currentGame.HasCheated)
                {
                    currentGame.BestTimeSpan = _currentElapsedTime;
                }
                listGames[currentGame.GameIndex] = currentGame;
                MessageBox.Show("Level Completed Successfully.");
                resultPane.Visible = true;
                dynamicTableLayoutPanel.Enabled = false;
                refreshScoreBoard(currentGame.GameLevel);
                _currentElapsedTime = TimeSpan.Zero;
                _totalElapsedTime = TimeSpan.Zero;
            }
        }

        private void RefreshDiagnols()
        {
            int d1 = 0;
            int d2 = 0,u_d2=0, u_d1 = 0;
            for (int row = 0, col = currentGame.GridLength - 1; row < currentGame.GridLength && col >= 0; row++, col--)
            {
                d1 += currentGame.PlayerBoard[row, row];
                d2 += currentGame.PlayerBoard[col, row];
                u_d2+= currentGame.AnswerBoard[col, row];
                u_d1 += currentGame.AnswerBoard[row, row];
            }
            currentGame.PlayerBoard[currentGame.GridLength, currentGame.GridLength] = d1;
            //currentGame.DisplayBoard[currentGame.GridLength, currentGame.GridLength + 1] = d1;
            Label txtUserSum_D1 = dynamicTableLayoutPanel.Controls.OfType<Label>().Where(t => t.Name.Equals("gridvalue_" + (currentGame.GridLength+1) + "_" + (currentGame.GridLength + 1))).FirstOrDefault() as Label;
            txtUserSum_D1.Text = d1.ToString();
            Label txtUserSum_D2 = dynamicTableLayoutPanel.Controls.OfType<Label>().Where(t => t.Name.Equals("gridvalue_0_" + (currentGame.GridLength + 1))).FirstOrDefault() as Label;
            Label txtDesiredSum_D2 = dynamicTableLayoutPanel.Controls.OfType<Label>().Where(t => t.Name.Equals("gridvalue_0_" + (currentGame.GridLength + 2))).FirstOrDefault() as Label;
            txtUserSum_D1.Text = d1.ToString();
            txtUserSum_D2.Text = d2.ToString();
            txtDesiredSum_D2.Text = u_d2.ToString();

            if (d1 == u_d1)
                txtUserSum_D1.ForeColor = Color.Green;
            if (u_d2 == d2)
                txtUserSum_D2.ForeColor = Color.Green;

        }

        private void fillDiagnolDesiredSum(GameBoard currentGame)
        {
            int d1 = 0;
            int d2 = 0;
            for(int row=0,col= currentGame.GridLength-1; row<currentGame.GridLength && col>=0;row++,col--)
            {
                d1 += currentGame.AnswerBoard[row, row];
                d2 += currentGame.AnswerBoard[row, row];
            }
            currentGame.PlayerBoard[currentGame.GridLength, currentGame.GridLength + 1] = d1;
            currentGame.DisplayBoard[currentGame.GridLength, currentGame.GridLength + 1] = d1;
        }

        private void refreshScoreBoard(DifficultyLevel difficultyLevel)
        {
            TimeSpan minTime = listGames.Where(g => g.GameLevel == difficultyLevel && g.GameStatus == GameStatus.Completed && g.HasCheated != true).Select(g => g.BestTimeSpan).Min();
            double  average = listGames.Where(g => g.GameLevel == difficultyLevel && g.GameStatus == GameStatus.Completed).Select(g => g.BestTimeSpan.TotalSeconds).Average();
            lblMinTime.Text = minTime.TotalSeconds.ToString() + " sec(s) in current level.";
            lblAverage.Text = average.ToString("F2") + " sec(s) in current level.";
        }

        private bool IsLevelCompleted()
        {
            bool levelFinished = true;
           for(int i=0;i<currentGame.GridLength && levelFinished;i++)
            {
                for(int j=0;j<2;j++)
                {
                    if (validateGrid[i, j] == 0)
                    {
                        levelFinished = false;
                        break;
                    }

                }
            }
            return levelFinished;
        }

        private void preFillUserSum()
        {
            int row = 0;
            int column = 0;
            int rowSum = 0, colSum = 0;
            bool rowFilled = true, columnFilled = true;
            for (row = 1, column = 1; column <= currentGame.GridLength; column++, row++)
            {

                Label txtUserSum_Row = dynamicTableLayoutPanel.Controls.OfType<Label>().Where(t => t.Name.Equals("gridvalue_" + row + "_" + (currentGame.GridLength + 1))).FirstOrDefault() as Label;
                //txtUserSum_Row.Text = rowSum.ToString();
                Label txtUserSum_Column = dynamicTableLayoutPanel.Controls.OfType<Label>().Where(t => t.Name.Equals("gridvalue_" + (currentGame.GridLength + 1) + "_" + column)).FirstOrDefault() as Label;
                //txtUserSum_Column.Text = colSum.ToString();

                TextBox txtDesiredSum_Row = dynamicTableLayoutPanel.Controls.OfType<TextBox>().Where(t => t.Name.Equals("gridvalue_" + row + "_" + (currentGame.GridLength + 2))).FirstOrDefault() as TextBox;
                TextBox txtDesiredSum_Column = dynamicTableLayoutPanel.Controls.OfType<TextBox>().Where(t => t.Name.Equals("gridvalue_" + (currentGame.GridLength + 2) + "_" + column)).FirstOrDefault() as TextBox;
                if (txtDesiredSum_Column.Text == txtUserSum_Column.Text)
                {
                    txtUserSum_Column.ForeColor = Color.Green;
                    validateGrid[column - 1, 1] = 1;
                    solvedCount++;
                }
                
                if (txtDesiredSum_Row.Text == txtUserSum_Row.Text)
                {
                    txtUserSum_Row.ForeColor = Color.Green;
                    validateGrid[row - 1, 0] = 1;
                    solvedCount++;
                }
                

            }
        }
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            base.OnPaint(e);
            System.Drawing.SolidBrush textBrush;

            //Set user selected backcolor when disabled
            if (this.Enabled)
            {
                textBrush = new System.Drawing.SolidBrush(this.ForeColor);
            }
            else
            {
                System.Drawing.Color backColorDisabled = Color.Green;
                if (this.Parent.FindForm() != null)
                {
                    backColorDisabled = this.Parent.FindForm().BackColor;
                }
                textBrush = new System.Drawing.SolidBrush(Color.Green);
                System.Drawing.SolidBrush backBrush = new System.Drawing.SolidBrush(backColorDisabled);
                e.Graphics.FillRectangle(backBrush, ClientRectangle);
            }

            //Paint text
            e.Graphics.DrawString(this.Text, this.Font, textBrush, 1.0F, 1.0F);
        }


        private void CalculateDesiredSum()
        {
            //int gridLength = currentGame.AnswerBoard.
            //for(int i)
        }

        private void PickGame(DifficultyLevel difficultyLevel)
        {
            currentGame = null;
            currentGame = listGames.Where(g => g.GameLevel == difficultyLevel && g.GameStatus == GameStatus.InProgress).FirstOrDefault();
            if(currentGame == null)
                currentGame = listGames.Where(g => g.GameLevel == difficultyLevel && g.GameStatus == GameStatus.UnSolved).FirstOrDefault();
            if (currentGame == null)
                currentGame = listGames.Where(g => g.GameLevel == difficultyLevel && g.GameStatus == GameStatus.Completed).FirstOrDefault();

            ValidateCount = (currentGame.GridLength * 2 + 2);
            solvedCount = 0;
            validateGrid = new int[currentGame.GridLength, 2];
        }

        private void Start_Click(object sender, EventArgs e)
        {
            Toggle_MaskChar();
            grpTimer.Visible = true;
            if (!_timerRunning)
            {
                // Set the start time to Now
                _startTime = DateTime.Now;

                // Store the total elapsed time so far
                _totalElapsedTime = _currentElapsedTime;

                _timer.Start();
                _timerRunning = true;
                btnStart.Text = "Pause";
                btnNewGame.Enabled = false;
            }
            else // If the timer is already running
            {
                btnNewGame.Enabled = true;
                currentGame.TimeSpan = _currentElapsedTime;
                currentGame.GameStatus = GameStatus.InProgress;
                listGames[currentGame.GameIndex] = currentGame;
                btnStart.Text = "Start";
                _timer.Stop();
                _timerRunning = false;
            }
        }

        private void Toggle_MaskChar()
        {
            char maskChar = Char.MinValue;
            maskChar = _timerRunning ? '?' : maskChar;
            foreach(TextBox txt in dynamicTableLayoutPanel.Controls.OfType<TextBox>())
            {
                txt.PasswordChar = maskChar;
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            foreach (TextBox txt in dynamicTableLayoutPanel.Controls.OfType<TextBox>().Where(t=>t.Enabled))
            {
                string[] idParts = txt.Name.Split('_');
                int row = Convert.ToInt32(idParts[1]);
                int column = Convert.ToInt32(idParts[2]);
                if(txt.Text != currentGame.AnswerBoard[row-1,column-1].ToString())
                {
                    txt.ForeColor = Color.Red;
                    currentGame.HasCheated = true;
                    txt.Focus();
                    txt.SelectionLength = 0;
                    break;
                }
            }
        }

        /// <summary>
        /// Handle Start/Stop button click
        /// </summary>
        /// <param name="sender">The Button control</param>
        /// <param name="e">EventArgs object</param>
        void _timer_Tick(object sender, EventArgs e)
        {
            // We do this to 'chop off' any stray milliseconds
            // resulting from the Timer's inherent inaccuracy,
            // with the bonus that the TimeSpan.ToString() method
            // will now show the correct HH:MM:SS format
            var timeSinceStartTime = DateTime.Now - _startTime;
            timeSinceStartTime = new TimeSpan(timeSinceStartTime.Hours,
                                              timeSinceStartTime.Minutes,
                                              timeSinceStartTime.Seconds);

            // The current elapsed time is the time since the start button
            // was clicked, plus the total time elapsed since the last reset
            _currentElapsedTime = timeSinceStartTime + _totalElapsedTime;

            // These are just two Label controls which display the current
            // elapsed time and total elapsed time
            totalTime_elapsed.Text = _currentElapsedTime.ToString();
            currentTime_elapsed.Text = timeSinceStartTime.ToString();
        }
    }
}
