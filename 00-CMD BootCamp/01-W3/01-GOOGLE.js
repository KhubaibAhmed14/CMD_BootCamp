// document.getElementById("seachBox").addEventListener("submit", function (event) {
//     event.preventDefault();
//     const urlInput = document.getElementById("toSearch").value;
//     window.location.href = "https://www.google.com/search?q=" + urlInput;
// });

document
  .getElementById("searchBox")
  .addEventListener("submit", function (event) {
    const urlInput= "https://www.google.com/search?q="+  document.getElementById("toSearch").value;
    window.location.href = urlInput;
  });
