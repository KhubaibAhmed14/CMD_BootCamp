document.addEventListener("DOMContentLoaded", function () {
  // Interactive Navigation Bar
  const navLinks = document.querySelectorAll("nav a");

  navLinks.forEach((link) => {
    link.addEventListener("mouseover", function () {
      this.style.color = "black";
      this.style.backgroundColor = "rgb(216, 202, 183)";
    });

    link.addEventListener("mouseout", function () {
      this.style.color = "white";
      this.style.backgroundColor = "black";
    });
  });

  // Image Switcher
  const switchButton = document.querySelectorAll(".sB");
  const imageDisplays = document.querySelectorAll(".bird-image img");
  const imageScr = [
    [
      "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b8/Turdus-migratorius-002.jpg/640px-Turdus-migratorius-002.jpg",
      "https://images.immediate.co.uk/production/volatile/sites/23/2019/01/GettyImages-480896680-91ed176.jpg",
    ],
    [
      "https://images.immediate.co.uk/production/volatile/sites/23/2019/01/GettyImages-480896680-91ed176.jpg",
      "https://t3.ftcdn.net/jpg/05/54/36/72/360_F_554367287_4HNoobM6ih46QB7cSpYO2Y9z6CeZeNQq.jpg",
    ],
    [
      "https://t3.ftcdn.net/jpg/05/54/36/72/360_F_554367287_4HNoobM6ih46QB7cSpYO2Y9z6CeZeNQq.jpg",
      "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b8/Turdus-migratorius-002.jpg/640px-Turdus-migratorius-002.jpg",
    ],
  ];

  var state = true;
  switchButton.forEach((button, index) => {
    button.addEventListener("click", function () {
      if (state) {
        imageUrl = imageScr[index][0];
        state = !state;
      } else {
        imageUrl = imageScr[index][1];
        state = !state;
      }
      imageDisplays[index].src = imageUrl;
    });
  });

  // Form Validation
  const form = document.querySelector("form");
  const nameInput = document.getElementById("name");
  const emailInput = document.getElementById("email");

  form.addEventListener("submit", function (event) {
    event.preventDefault();

    if (nameInput.value.trim() === "" || !validateEmail(emailInput.value)) {
      alert("Please fill all the fields correctly.");
    } else {
      form.submit();
    }
  });

  function validateEmail(email) {
    const emailPattern = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
    return emailPattern.test(email);
  }

  // Interactive Table
  const table = document.querySelector("table");
  const addButton = document.getElementById("add-row-button");

  addButton.addEventListener("click", function () {
    const newRow = table.insertRow(-1);
    const columns = ["Species", "Habitat", "Food", "wieght"];
    columns.forEach((column) => {
        const cell = newRow.insertCell();
        const input = document.createElement("input");
        input.type = "text";
        input.placeholder = `Enter ${column}`;
        cell.appendChild(input);
  });
});

});
