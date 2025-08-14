using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthTrackerModule1
{
    public partial class Form1 : Form
    {
        private int[] dailySteps = new int[7];
        private int currentDay = 0;
        private int stepGoal = 0;

        public Form1()
        {
            InitializeComponent();
            // Optional: lblDayCount.Text = "Day 1 of 7";
        }

        private void btnAddSteps_Click(object sender, EventArgs e)
        {
            if (currentDay >= 7)
            {
                MessageBox.Show("You have already entered steps for all 7 days.");
                // TODO (Worksheet): Also disable the Add Steps button here:
                // btnAddSteps.Enabled = false;
                return;
            }

            // BUG (Worksheet): no input validation, using int.Parse can throw on bad input
            // TODO (Worksheet): Replace with int.TryParse and reject negatives.
            int steps = int.Parse(txtSteps.Text);

            dailySteps[currentDay] = steps;

            lstDailySteps.Items.Add($"Day {currentDay + 1}: {steps} steps");

            currentDay++;
            lblDayCount.Text = $"Day {currentDay + 1} of 7"; // NOTE: shows "Day 8 of 7" after the 7th entry; students can refine if they want.

            txtSteps.Clear();
            txtSteps.Focus();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // BUG (Worksheet): no validation for stepGoal input
            // TODO (Worksheet): Replace with int.TryParse and reject negatives.
            stepGoal = int.Parse(txtStepGoal.Text);

            int totalSteps = 0;
            int daysBelowGoal = 0;

            // BUG (Worksheet): Off-by-one loop will crash on index 7
            // TODO (Worksheet): Fix to iterate only over entered days
            for (int i = 0; i <= 7; i++)
            {
                totalSteps += dailySteps[i];
                if (dailySteps[i] < stepGoal)
                    daysBelowGoal++;
            }

            // BUG (Worksheet): integer division truncates; should be double
            // TODO (Worksheet): Make averageSteps a double and divide by currentDay (not fixed 7)
            int averageSteps = totalSteps / 7;

            // --- Optional: Highest/Lowest (students can choose to add) ---
            // TODO (Worksheet): Calculate highest/lowest day and display.

            // --- Iterative vs Recursive comparison (prebuilt; students compare outputs) ---
            // NOTE: This uses the whole 7-element array for simplicity here.
            // TODO (Worksheet): Consider using only the entered portion (first currentDay items).
            int modeValue = ComputeMode(dailySteps, 7); // students can change 7 -> currentDay
            int iterativeCount = CountOccurrencesIterative(modeValue, dailySteps);
            int recursiveCount = CountOccurrencesRecursive(modeValue, dailySteps);

            lblOutput.Text =
                $"Average steps per day: {averageSteps}\n" +
                $"Days below goal: {daysBelowGoal}\n" +
                $"Most common (mode): {modeValue}\n" +
                $"Iterative count of mode: {iterativeCount}\n" +
                $"Recursive count of mode: {recursiveCount}";

            // TODO (Worksheet): Add a Reset button to clear data, re-enable Add, and reset labels.
        }

        // ----------------- Helpers for mode (simple dictionary approach) -----------------
        // NOTE: Students don’t need to change this; it’s here to support comparison.
        private static int ComputeMode(int[] data, int count)
        {
            if (count <= 0) return 0;

            var freq = new Dictionary<int, int>();
            for (int i = 0; i < count; i++)
            {
                int v = data[i];
                if (!freq.ContainsKey(v)) freq[v] = 0;
                freq[v]++;
            }

            int bestValue = data[0];
            int bestCount = 0;
            foreach (var kvp in freq)
            {
                if (kvp.Value > bestCount)
                {
                    bestCount = kvp.Value;
                    bestValue = kvp.Key;
                }
                // Tie behavior: keeps the first max encountered; students can discuss/adjust.
            }
            return bestValue;
        }

        // ----------------- Iterative vs Recursive counting (pre-filled) ------------------
        private static int CountOccurrencesIterative(int value, int[] list)
        {
            int count = 0;
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i] == value) count++;
            }
            return count;
        }

        private static int CountOccurrencesRecursive(int value, int[] list, int index = 0)
        {
            if (index == list.Length) return 0;
            int match = (list[index] == value) ? 1 : 0;
            return match + CountOccurrencesRecursive(value, list, index + 1);
        }
    }
}
