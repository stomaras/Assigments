let trainers = [];

//button elements
let btnRegister = document.getElementById("submit");
let btnReset = document.getElementById("reset");
let btnUpdate = document.getElementById("update");

// HTML tag elements
let firstName = document.getElementById("firstName");
let lastName = document.getElementById("lastName");
let email = document.getElementById("email");
let course = document.getElementById("course");
let password = document.getElementById("password");
let confirmPassword = document.getElementById("confirmPassword");

// Event Listeners
btnRegister.addEventListener("click", register);
btnReset.addEventListener("click", reset);
btnUpdate.addEventListener("click", update);

function Trainer(
  firstName,
  lastName,
  email,
  course,
  password,
  confirmPassword
) {
  this.firstName = firstName;
  this.lastName = lastName;
  this.email = email;
  this.course = course;
  this.password = password;
  this.confirmPassword = confirmPassword;
}

function toStringTrainer(trainer) {
  return `${trainer.firstName} ${trainer.lastName} ${trainer.email} ${trainer.course} ${trainer.password} ${trainer.confirmPassword}`;
}

function register(event) {
  event.preventDefault();

  let myTrainer = new Trainer(
    firstName.value,
    lastName.value,
    email.value,
    course.value,
    password.value,
    confirmPassword.value
  );

  if (
    firstName.value != "" &&
    lastName.value != "" &&
    email.value != "" &&
    course.value != "" &&
    password.value != "" &&
    confirmPassword.value != ""
  ) {
    console.log(myTrainer);
    let editBtn = createEditButton();
    trainers.push(myTrainer);
    createSectionElement(myTrainer, editBtn);

    editBtn.trainersIndex = trainers.length - 1;
    editBtn.addEventListener("click", edit);
    btnReset.click();
  } else {
  }
}

function reset() {
  btnRegister.textContent = "Register";
}

function createSectionElement(trainer, editButton) {
  let section = document.createElement("section");
  section.setAttribute("id", "section");

  let ul = document.createElement("ul");
  document.body.appendChild(section);
  section.appendChild(ul);

  var li = document.createElement("li");
  ul.appendChild(li);

  var span = document.createElement("span");
  span.innerHTML = "&nbsp;&nbsp;";
  li.innerHTML = toStringTrainer(trainer);
  li.appendChild(span);
  li.append(editButton);
}

function createEditButton() {
  let btnEdit = document.createElement("button");
  btnEdit.textContent = "Edit";
  return btnEdit;
}

function edit(event) {
  firstName.value = trainers[this.trainersIndex].firstName;
  lastName.value = trainers[this.trainersIndex].lastName;
  email.value = trainers[this.trainersIndex].email;
  course.value = trainers[this.trainersIndex].course;
  password.value = trainers[this.trainersIndex].password;
  confirmPassword.value = trainers[this.trainersIndex].confirmPassword;
  btnRegister.hidden = true;
  btnUpdate.hidden = false;
  btnUpdate.trainersIndex = this.trainersIndex;
}

function update(event) {
  event.preventDefault();
  trainers[this.trainersIndex] = new Trainer(
    firstName.value,
    lastName.value,
    email.value,
    course.value,
    password.value,
    confirmPassword.value
  );

  for (let i = 0; i <= trainers.length - 1; i++) {
    let section = document.createElement("section");
    section.setAttribute("id", "section");

    let ul = document.createElement("ul");
    document.body.appendChild(section);
    section.appendChild(ul);

    var li = document.createElement("li");
    ul.appendChild(li);

    var span = document.createElement("span");
    span.innerHTML = "&nbsp;&nbsp;";
    li.innerHTML = toStringTrainer(trainers[i]);
    li.appendChild(span);
    li.append(editButton);
  }
}
