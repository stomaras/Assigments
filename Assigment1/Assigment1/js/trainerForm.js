let trainers = [];
const courses = ["csharp", "java", "python", "javascript"];
let trainerForm = document.getElementById("signup");

let firstNameInput = document.getElementById("firstName");
let lastNameInput = document.getElementById("lastName");
let emailInput = document.getElementById("email");
let passwordInput = document.getElementById("password");
let confirmPasswordInput = document.getElementById("confirmPassword");
let courseInput = document.getElementById("course");

let btnRegister = document.getElementById("submit");
let btnReset = document.getElementById("reset");

// error message initialization
let message = "";

function Trainer(
  firstName,
  lastName,
  email,
  password,
  confirmPassword,
  course
) {
  this.firstName = firstName;
  this.lastName = lastName;
  this.email = email;
  this.password = password;
  this.confirmPassword = confirmPassword;
  this.course = course;
}

function trainerToString(trainer) {
  return `Trainer with [first name: ${trainer.firstName} ,last name:${trainer.lastName} ,email:${trainer.email} ,password:${trainer.password} ,confirm password:${trainer.confirmPassword},course:${trainer.course}]`;
}

btnRegister.addEventListener("click", function (e) {
  e.preventDefault();
  let firstName = firstNameInput.value;
  let lastName = lastNameInput.value;
  let email = emailInput.value;
  let password = passwordInput.value;
  let confirmPassword = confirmPasswordInput.value;
  let course = courseInput.value;

  let mytrainer = new Trainer(
    firstNameInput.value,
    lastNameInput.value,
    emailInput.value,
    passwordInput.value,
    confirmPasswordInput.value,
    courseInput.value
  );

  let validFirstNameMessage = validateFirstName(firstNameInput, message);
  let validLastNameMessage = validateLastName(lastNameInput, message);
  let validEmail = validateEmail(emailInput);
  const validPassword = validatePassword(passwordInput);
  const validConfirmPassword = validateConfirmPassword(
    passwordInput,
    confirmPasswordInput
  );
  let validCourseMessage = validateCourse(courses, courseInput, message);
  //let validCourse = validateCourse(courses, courseInput);

  if (
    validFirstNameMessage == "" &&
    validLastNameMessage == "" &&
    validEmail &&
    validPassword &&
    validConfirmPassword &&
    validCourseMessage == ""
  ) {
    trainers.push(mytrainer);

    // Creation of unordered list triners
    const div = document.getElementById("trainers");
    const ul = document.getElementById("theList");
    let li = createListElement();
    ul.appendChild(li);
    let paragraph = createParagraphElement(mytrainer);
    li.appendChild(paragraph);
    let editbutton = createEditButton();
    editbutton.trainerIndex = trainers.length - 1;
    editbutton.addEventListener("click", edit);
    let span = document.createElement("span");
    span.innerHTML = "&nbsp&nbsp";
    paragraph.append(span, editbutton);

    console.log(editbutton);

    btnReset.click();
  } else if (validFirstNameMessage !== "") {
    alert(validFirstNameMessage);
  } else if (validLastNameMessage !== "") {
    alert(validLastNameMessage);
  } else if (validEmail == false) {
    alert(
      "Email must be filled and contain (@) symbol, (.) symbol and be at least 11 characters long"
    );
  } else if (validPassword == false) {
    alert("Password must be filled or be at least 3 characters long");
  } else if (validConfirmPassword == false) {
    alert("Password and Confirm Password must be same");
  } else if (validCourseMessage !== "") {
    alert(validCourseMessage);
  }
});

function edit(event) {
  console.log(trainers[this.trainerIndex]);
  firstNameInput.value = trainers[this.trainerIndex].firstName;
  lastNameInput.value = trainers[this.trainerIndex].lastName;
  emailInput.value = trainers[this.trainerIndex].email;
  passwordInput.value = trainers[this.trainerIndex].password;
  confirmPasswordInput.value = trainers[this.trainerIndex].confirmPassword;
  courseInput.value = trainers[this.trainerIndex].course;

  console.log(trainerToString(trainers[this.trainerIndex]));
}

// function to create a list html element
function createListElement() {
  let li = document.createElement("li");
  li.setAttribute("class", "listElement");
  return li;
}

// function to create a paragraph element
function createParagraphElement(content) {
  let paragraph = document.createElement("p");
  paragraph.setAttribute("class", "paragraphElement");
  paragraph.innerHTML = trainerToString(content);
  return paragraph;
}

// function to create a edit button element
function createEditButton() {
  let button = document.createElement("button");
  button.setAttribute("class", "editButton");
  button.textContent = "Edit";
  return button;
}

/*
Validation Functions for input fields
1. validateFirstName()
2. validateLastName()
3. validateEmail()
4. validatePassword()
5. validateConfirmPassword()
6. validateCourse()
*/

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
  var regLastName = /^[a-zA-Z]/;

  let lastNamee = lastNameInput.value.trim();

  if (lastNamee == "") {
    message = "Last Name must not be blank!";
  } else if (lastNamee.length < min || lastNamee.length > max) {
    message = "Last Name must be between 2 and 25 characters long!";
  } else if (!regLastName.test(lastNamee)) {
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
