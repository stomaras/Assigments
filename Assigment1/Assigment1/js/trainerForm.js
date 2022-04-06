let trainers = [];
let courses = [csharp, java, python, javascript];
let trainerForm = document.getElementById("signup");

let firstNameInput = document.getElementById("firstName");
let lastNameInput = document.getElementById("lastName");
let emailInput = document.getElementById("email");
let passwordInput = document.getElementById("password");
let confirmPasswordInput = document.getElementById("confirmPassword");
let courseInput = document.getElementById("course");

let btnRegister = document.getElementById("submit");
let btnReset = document.getElementById("reset");

let count = 0;

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

  let validFirstName = validateFirstName(firstNameInput);
  let validLastName = validateLastName(lastNameInput);
  let validEmail = validateEmail(emailInput);
  const validPassword = validatePassword(passwordInput);
  const validConfirmPassword = validateConfirmPassword(
    passwordInput,
    confirmPasswordInput
  );
  if (
    validFirstName &&
    validLastName &&
    validEmail &&
    validPassword &&
    validConfirmPassword
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
    let span = document.createElement("span");
    span.innerHTML = "&nbsp&nbsp";
    paragraph.append(span, editbutton);

    btnReset.click();
  } else if (validFirstName == false) {
    alert("First Name must be filled and be between 2 or 25 characters long");
  } else if (validLastName == false) {
    alert("Last Name must be filled and be between 2 or 25 characters long");
  } else if (validEmail == false) {
    alert(
      "Email must be filled and contain (@) symbol, (.) symbol and be at least 11 characters long"
    );
  } else if (validPassword == false) {
    alert("Password must be filled or be at least 8 characters long");
  } else if (validConfirmPassword == false) {
    alert("Confirm Password must be same with Password field");
  }
});

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
function validateFirstName(firstNameInput) {
  const min = 2;
  const max = 25;
  let valid = true;

  let firstNamee = firstNameInput.value.trim();

  if (firstNamee == "") {
    valid = false;
  } else if (firstNamee.length < min || firstNamee.length > max) {
    valid = false;
  }
  return valid;
}

// 2. validateLastName()
function validateLastName(lastNameInput) {
  const min = 2;
  const max = 25;
  let valid = true;

  let lastNamee = lastNameInput.value.trim();

  if (lastNamee == "") {
    valid = false;
  } else if (lastNamee.length < min || lastNamee.length > max) {
    valid = false;
  }
  return valid;
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
  const min = 8;
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

// 6 validateCourse
function validateCourse(courseInput, courses) {
  let valid = true;
  let course = courseInput.value.trim().toLowerCase();

  for(var i=0; i < courses.length - 1; i++){
    if(course.)
  }
}
