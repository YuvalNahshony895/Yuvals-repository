// Toggling the navigation menu on button click
const toggleBtn = document.querySelector('.toggle-btn'); // Selecting the toggle button
const navbar = document.querySelector('.navbar'); // Selecting the navbar

toggleBtn.addEventListener('click', () => {
  navbar.classList.toggle('active'); // Toggling the 'active' class to show/hide the navbar
});

// Automatic slideshow for a carousel
let slideIndex = 0; // Initializing the index for slides
const slides = document.getElementsByClassName("slide"); // Selecting all elements with the class 'slide'

function showSlides() {
  for (let i = 0; i < slides.length; i++) {
    slides[i].style.display = "none"; // Hiding all slides initially
  }
  slideIndex++;
  if (slideIndex > slides.length) {
    slideIndex = 1; // Resetting index to show the first slide after reaching the last slide
  }
  slides[slideIndex - 1].style.display = "block"; // Displaying the current slide
  setTimeout(showSlides, 2000); // Change slide every 2 seconds (automatic slideshow)
}

showSlides(); // Initiating the automatic slideshow

// Smooth scrolling for anchor links
document.querySelectorAll('a[href^="#"]').forEach(anchor => {
  anchor.addEventListener('click', function(e) {
    e.preventDefault();

    const target = document.querySelector(this.getAttribute('href'));
    target.scrollIntoView({
      behavior: 'smooth', // Smooth scrolling effect
      block: 'start' // Scrolling to the start of the target element
    });
  });
});
