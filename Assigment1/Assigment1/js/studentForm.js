let students = [];

let btnRegister = document.getElementById("submit");
btnRegister.addEventListener("click", register);

let btnReset = document.getElementById("reset");
btnReset.addEventListener("click", reset);

let btnUpdate = document.getElementById("update");
btnUpdate.addEventListener("click", update);

let divStudents = document.getElementById("students");

let firstName = document.getElementById("firstName");
let lastName = document.getElementById("lastName");
let email = document.getElementById("email");
let password = document.getElementById("password");
let confirmPassword = document.getElementById("confirmPassword");

function Student(firstName, lastName, password, confirmPassword, email) {
  this.firstName = firstName;
  this.lastName = lastName;
  this.password = password;
  this.confirmPassword = confirmPassword;
  this.email = email;
}

function studentToString(student) {
  return `${student.firstName} ${student.lastName}  ${student.email} ${student.password} ${student.confirmPassword}`;
}

function register(event) {
  event.preventDefault();

  let myStudent = new Student(
    firstName.value,
    lastName.value,
    password.value,
    confirmPassword.value,
    email.value
  );
  students.push(myStudent);
  // create an HTML element
  // create an edit button
  let btnEdit = createEditButton();
  // custom attribute , inside any html element i can create my own attributes
  // Creation of my own custom attributes inside HTML elements tags
  btnEdit.studentIndex = students.length - 1;
  btnEdit.addEventListener("click", edit);
  // somehow bind the button to an element of the array
  // append this HTML element to document object
  createParagraphElement(myStudent, btnEdit);
  btnReset.click();

  console.log(myStudent);
}

function reset() {
  console.log("Form is reset");
  btnRegister.textContent = "Register";
}

function createParagraphElement(student, editButton) {
  let paragraph = document.createElement("p");
  paragraph.innerHTML = studentToString(student);
  let span = document.createElement("span");
  span.innerHTML = "&nbsp;&nbsp;";
  paragraph.append(span, editButton);
  divStudents.append(paragraph);
}

// Creation of Button Edit
function createEditButton() {
  let btnEdit = document.createElement("button");
  btnEdit.textContent = "Edit";
  return btnEdit;
}

function edit(event) {
  firstName.value = students[this.studentIndex].firstName;
  lastName.value = students[this.studentIndex].lastName;
  email.value = students[this.studentIndex].email;
  password.value = students[this.studentIndex].password;
  confirmPassword.value = students[this.studentIndex].confirmPassword;
  btnRegister.hidden = true;
  btnUpdate.hidden = false;
  btnUpdate.studentIndex = this.studentIndex;
  //   btnRegister.textContent = "Update";
  //   btnRegister.addEventListener("click", update);
  // from edit button i get studentIndex and pass it in submit button
  btnUpdate.studentIndex = this.studentIndex;
  //   btnUpdate.student = new Student(
  //     firstName.value,
  //     lastName.value,
  //     password.value,
  //     confirmPassword.value,
  //     email.value
  //   );
  console.log(studentToString(students[this.studentIndex]));
}

function update(event) {
  event.preventDefault();
  console.log(this.studentIndex);
  console.log(
    studentToString(
      new Student(
        firstName.value,
        lastName.value,
        password.value,
        confirmPassword.value,
        email.value
      )
    )
  );
  students[this.studentIndex] = new Student(
    firstName.value,
    lastName.value,
    password.value,
    confirmPassword.value,
    email.value
  );
  divStudents.innerHTML = " ";
  for (let i = 0; i < students.length; i++) {
    let btnEdit = document.createElement("button");
    btnEdit.textContent = "Edit";
    btnEdit.studentIndex = i;
    btnEdit.addEventListener("click", edit);
    createParagraphElement(students[i], btnEdit);
  }
  btnUpdate.hidden = true;
  btnRegister.hidden = false;
  btnReset.click();
}
