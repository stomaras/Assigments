let students = [];
const courses = ["csharp", "java", "python", "javascript"];

/*
MyOwn Counters for custom HTML built in eklements
*/
// counter for p element in order to initialize id each time a new
// paragraph element created
let count = 0;

// Get All Appropriate Inputs
let firstNameInput = document.getElementById("firstName");
let lastNameInput = document.getElementById("lastName");
let emailInput = document.getElementById("email");
let passwordInput = document.getElementById("password");
let confirmPasswordInput = document.getElementById("confirmPassword");
let courseInput = document.getElementById("course");
const radioButtonsInputs = document.querySelectorAll(
  'input[name="flexRadioDefault"]'
);

// error message initialization
let message = "";

// Get All Buttons
const btnRegister = document.getElementById("submit");
const btnReset = document.getElementById("reset");

btnRegister.addEventListener("click", register);
btnReset.addEventListener("click", reset);

function Student(
  firstName,
  lastName,
  email,
  password,
  confirmPassword,
  course,
  gender
) {
  this.firstName = firstName;
  this.lastName = lastName;
  this.email = email;
  this.password = password;
  this.confirmPassword = confirmPassword;
  this.course = course;
  this.gender = gender;
}

function toStringStudent(student) {
  return `Student [first name: ${student.firstName}, last name: ${student.lastName}, email: ${student.email}, password: ${student.password}, confirm password: ${student.confirmPassword}, course selected: ${student.course}, gender: ${student.gender}]`;
}

function register(event) {
  event.preventDefault();
  let firstName = firstNameInput.value;
  let lastName = lastNameInput.value;
  let email = emailInput.value;
  let password = passwordInput.value;
  let confirmPassword = confirmPasswordInput.value;
  let course = courseInput.value;
  let gender = checkedRadioButton(radioButtonsInputs);

  let validFirstNameMessage = validateFirstName(firstNameInput, message);
  let validLastNameMessage = validateLastName(lastNameInput, message);
  let validEmail = validateEmail(emailInput);
  let validPassword = validatePassword(passwordInput);
  let validConfirmPassword = validateConfirmPassword(
    passwordInput,
    confirmPasswordInput
  );
  let validCourseMessage = validateCourse(courses, courseInput, message);
  if (
    validFirstNameMessage == "" &&
    validLastNameMessage == "" &&
    validEmail &&
    validPassword &&
    validConfirmPassword &&
    validCourseMessage == ""
  ) {
    let myStudent = new Student(
      firstName,
      lastName,
      email,
      password,
      confirmPassword,
      course,
      gender
    );

    students.push(myStudent);
    // Creation of unordered list students
    const divStudents = document.getElementById("students");
    const ul = document.getElementById("theList");
    let li = createListElement();
    ul.appendChild(li);
    let paragraph = createParagraph(myStudent);
    li.appendChild(paragraph);
    let editButton = createEditButton();
    editButton.studentIndex = students.length - 1;
    editButton.addEventListener("click", edit);
    let span = createSpan();
    span.innerHTML = "&nbsp&nbsp";
    paragraph.append(span, editButton);

    btnReset.click();
  } else if (validFirstNameMessage !== "") {
    alert(validFirstNameMessage);
  } else if (validLastNameMessage !== "") {
    alert(validLastNameMessage);
  } else if (validEmail == false) {
    alert(" Email must be filled and contains (@) symbol and (.) symbol");
  } else if (validPassword == false) {
    alert(" Password must be filled and be at least 3 characters long");
  } else if (validConfirmPassword == false) {
    alert(" Confirm password must be filled and be equal with password");
  } else if (validCourseMessage !== "") {
    alert(validCourseMessage);
  }
}

function edit(event) {
  console.log(students[this.trainerIndex]);
  firstNameInput.value = students[this.studentIndex].firstName;
  lastNameInput.value = students[this.studentIndex].lastName;
  emailInput.value = students[this.studentIndex].email;
  passwordInput.value = students[this.studentIndex].password;
  confirmPasswordInput.value = students[this.studentIndex].confirmPassword;
  courseInput.value = students[this.studentIndex].course;

  console.log(trainerToString(students[this.studentIndex]));
}

//////////////////////////////////////////////////////////////////////////////////////////////////////////// CREATION OF DOM ELEMENTS //////////////////////////////
function createListElement() {
  let li = document.createElement("li");
  li.setAttribute("class", "listItem");
  return li;
}

function createParagraph(myStudent) {
  let paragraph = document.createElement("p");
  paragraph.setAttribute("id", count);
  paragraph.innerHTML = toStringStudent(myStudent);
  count++;
  return paragraph;
}

function createEditButton() {
  let button = document.createElement("button");
  button.setAttribute("class", "editButton");
  button.textContent = "Edit";
  return button;
}

function createSpan() {
  let span = document.createElement("span");
  return span;
}

//////////////////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////////////

////////////////////////////////////////////////////////////////////////////
//////////////////// VALIDATIONS ///////////////////////////////////////////

// 1. validateFirstName()
function validateFirstName(firstNameInput, message) {
  const min = 2;
  const max = 25;
  var regName = /^[a-zA-Z]/;
  let firstNamee = firstNameInput.value.trim();

  if (firstNamee == "") {
    message = "First Name must not be blank!";
  } else if (firstNamee.length < min || firstNamee.length > max) {
    message = "First Name must be between 2 and 25 characters long!";
  } else if (!regName.test(firstNamee)) {
    message = "First Name can not contain symbols and numbers!";
  }
  return message;
}

// 2. validateLastName()
function validateLastName(lastNameInput, message) {
  const min = 2;
  const max = 25;
  var regName = /^[a-zA-Z]/;

  let lastNamee = lastNameInput.value.trim();

  if (lastNamee == "") {
    message = "Last Name must not be blank!";
  } else if (lastNamee.length < min || lastNamee.length > max) {
    message = "Last Name must be between 2 and 25 characters long!";
  } else if (!regName.test(lastNamee)) {
    message = "Last Name can not contain symbols and numbers!";
  }
  return message;
}

// 3. validateEmail
function validateEmail(emailInput) {
  const emailRegex =
    /^(([^<>()\[\]\\.,;:\s@"]+(\.[^<>()\[\]\\.,;:\s@"]+)*)|(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;
  const email = emailInput.value.trim();
  let valid = true;

  if (email == "") {
    valid = false;
  } else if (!emailRegex.test(email)) {
    valid = false;
  } else if (email.length < 12) {
    valid = false;
  }
  return valid;
}

// 4. validatePassword
function validatePassword(passwordInput) {
  const min = 3;
  let valid = true;
  const password = passwordInput.value.trim();

  if (password == "" || password.length < min) {
    valid = false;
  }

  return valid;
}

// 5. validateConfirmPassword
function validateConfirmPassword(passwordInput, confirmPasswordInput) {
  let valid = true;
  const password = passwordInput.value.trim();
  const confirmPassword = confirmPasswordInput.value.trim();

  if (password !== confirmPassword) {
    valid = false;
  }
  return valid;
}

// 6. validateCourse
function validateCourse(courses, courseInput, message) {
  var regCourse = /^[a-zA-Z]/;
  let course = courseInput.value.trim().toLowerCase();

  if (course === "") {
    message = "Course Field must not be blank!";
  } else if (!regCourse.test(course)) {
    message = "Course can't contain special characters and numbers";
  } else {
    for (var i = 0; i < courses.length; i++) {
      if (courses[i] === course) {
        message = "";
        return message;
      }
    }
    message =
      "Course field must be csharp (or) java (or) python (or) javascript!";
  }
  return message;
}

/////////////////////////////////////////////////////////////////////////////////
/////////////////////////////// HELPER FUNCTIONS ///////////////////////////////

function checkedRadioButton(arrayRadioButtons) {
  let selectedRadio;
  for (const radioButton of arrayRadioButtons) {
    if (radioButton.checked) {
      selectedRadio = radioButton.value;
      break;
    }
  }
  return selectedRadio;
}
