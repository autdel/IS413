// JS to calculate the final grade

$("#calculate").click(function () {
    let assignments = document.getElementById("assignments").value;
    let groupProjects = document.getElementById("groupProjects").value;


    let quizzes = document.getElementById("quizzes").value;
    let midtermExam = document.getElementById("midtermExam").value;
    let finalExam = document.getElementById("finalExam").value;
    let intex = document.getElementById("intex").value;


    let finalGradeValue = (assignments * .5) + (groupProjects * .1) + (quizzes * .1) + (midtermExam * .1) + (finalExam * .1) + (intex * .1);
    let finalGradeText = document.getElementById("finalGrade");

    let letterGrade = "";
    if (finalGradeValue >= 94) {
        letterGrade = "A"
    }
    else if (finalGradeValue >= 90) {
        letterGrade = "A-"
    }
    else if (finalGradeValue >= 87) {
        letterGrade = "B+"
    }
    else if (finalGradeValue >= 84) {
        letterGrade = "B"
    }
    else if (finalGradeValue >= 80) {
        letterGrade = "B-"
    }
    else if (finalGradeValue >= 77) {
        letterGrade = "C+"
    }
    else if (finalGradeValue >= 74) {
        letterGrade = "C"
    }
    else if (finalGradeValue >= 70) {
        letterGrade = "C-"
    }
    else if (finalGradeValue >= 67) {
        letterGrade = "D+"
    }
    else if (finalGradeValue >= 64) {
        letterGrade = "D"
    }
    else if (finalGradeValue >= 60) {
        letterGrade = "D-"
    }
    else {
        letterGrade = "E"
    }

    finalGradeText.style.display = "block";
    finalGradeText.innerHTML += "Your final grade is " + finalGradeValue + ", so your final letter grade is: " + letterGrade;
})