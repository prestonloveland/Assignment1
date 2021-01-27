/*Preston Loveland
Assignment 1 IS 414
Group 11 Section 1 */
function calculate_grade()
{
    //declare variables
    var assignments = $("#assignments")[0].value;
    var group_projects = $("#group-project")[0].value;
    var quizzes = $("#quizzes")[0].value;
    var exams = $("#exams")[0].value;
    var intex = $("#intex")[0].value;
    var final_grade = 0;
    var letter_grade = "";
    //calculate grade
    final_grade = (.50 * assignments) + (.10 * group_projects) + (.10 * quizzes) + (.20 * exams) + (.10 * intex);

    //get letter grade
    if (final_grade >= 94) {
        letter_grade = "A";
    } else if (final_grade >= 90) {
        letter_grade = "A-";
    } else if (final_grade >= 87) {
        letter_grade = "B+";
    } else if (final_grade >= 84) {
        letter_grade = "B";
    } else if (final_grade >= 80) {
        letter_grade = "B-";
    } else if (final_grade >= 77) {
        letter_grade = "C+";
    } else if (final_grade >= 74) {
        letter_grade = "C";
    } else if (final_grade >= 70) {
        letter_grade = "C-";
    } else if (final_grade >= 67) {
        letter_grade = "D+";
    } else if (final_grade >= 64) {
        letter_grade = "D";
    } else if (final_grade >= 60) {
        letter_grade = "D-";
    } else {
        letter_grade = "E";
    }

    //send alert
    alert("Final Grade: " + final_grade + " : " + letter_grade);
}