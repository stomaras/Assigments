const usernameEl = document.querySelector("#username");
const emailEl = document.querySelector("#email");
const passwordEl = document.querySelector("#password");
const confirmPasswordEl = document.querySelector("#confirm-password");

const form = document.querySelector("#signup");

form.addEventListener("submit", function (e) {
  // prevent the form from submitting
  e.preventDefault();
});

// Develop utility methods

// The following isRequired() function returns true if the input argument is empty
const isRequired = (value) => (value === "" ? false : true);

// The following isBetween() function returns false if the length argument is not between the min and max length
const isBetween = (length, min, max) =>
  length < min || length > max ? false : true;

// To check the email is valid, i will use a regular expression
const isEmailValid = (email) => {
  const re =
    /^(([^<>()\[\]\\.,;:\s@"]+(\.[^<>()\[\]\\.,;:\s@"]+)*)|(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;
  return re.test(email);
};

//To check if a password is strong, which match a specified pattern, you’ll also use a regular expression
const isPasswordSecure = (password) => {
  const re = new RegExp(
    "^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[!@#$%^&*])(?=.{8,})"
  );
  return re.test(password);
};

const showError = (input, message) => {
  // get the form-field element
  // to get the parent element of the input field, which is the <div> element
  // thet contains the form class
  const formField = input.parentElement;
  // Second, remove the success class and add the error class to the form-field element:
  formField.classList.remove("success");
  formField.classList.add("error");
  // Third select the <small> element inside the form-field element
  const error = formField.querySelector("small");
  // I use formField.querySelector() instead of the document.querySelector().
  // Finally i set the error message to its textContent property of the small element
  error.textContent = message;
};

const showSuccess = (input) => {
  // get the form field element
  const formField = input.parentElement;

  // remove the error class
  formField.classList.remove("error");
  formField.classList.add("success");

  // hide the error message
  const error = formField.querySelector("small");
  error.textContent = "";
};

/*
Develop input field validating functions
I will develop four functions for validating values of the form fields:
*/

/*
1) Validate the username field

The following checkUsername() function uses:
    - The isRequired() function to check id the username is provided.
    - The isBetween() function to check if the length of the username is between 3 and 25
    - The showError() and showSuccess() functions to show the error and success indicator
    The function returns true if the field passes the checks.
*/

const checkUsername = () => {
  let valid = false;
  const min = 3,
    mac = 25;
  const username = usernameEl.value.trim();

  if (!isRequired(username)) {
    showError(usernameEl, "Username cannot be blank.");
  } else if (!isBetween(username.length, min, max)) {
    showError(
      usernameEl,
      `Username must be between ${min} and ${max} characters`
    );
  } else {
    showSuccess(usernameEl);
    valid = true;
  }
  return valid;
};
