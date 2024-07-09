


  // Function to create and add the global header
function createHeader() {
    const header = document.createElement('header');
    header.innerHTML = `
      <div class="logo">
        <img src="static/img/logo.png" alt="Company Logo">
      </div>
      <button class="toggle-btn-header">&#9776;</button>
      <nav>
        <ul class="navbar">
          <li><a href="index.html">Home</a></li>
          <li><a href="about.html">About</a></li>
          <li><a href="services.html">Services</a></li>
          <li><a href="contact.html">Contact</a></li>
        </ul>
      </nav>
    `;
    document.body.prepend(header);
  
    // Add event listener for the toggle button in header
    const toggleBtnHeader = header.querySelector('.toggle-btn-header');
    const navbarHeader = header.querySelector('.navbar');
  
    toggleBtnHeader.addEventListener('click', () => {
      navbarHeader.classList.toggle('active');
    });
  }
  

   
  // Function to create and add the global footer
  function createFooter() {
    const footer = document.createElement('footer');
    footer.innerHTML = `
      <div class="footer-content">
        <div class="footer-section about">
          <h3>About Us</h3>
          <p>We are dedicated to preserving the legacy of Broadway Stores, Inc. and its impact on the retail industry.</p>
        </div>
        <div class="footer-section contact">
          <h3>Contact Information</h3>
          <p>
            Address: 1234 Broadway Street, Los Angeles, CA<br>
            Phone: +1 (123) 456-7890<br>
            Email: funkyfresh1200@yahoo.com
          </p>
        </div>
        <div class="footer-section links">
          <h3>Quick Links</h3>
          <ul>
            <li><a href="index.html">Home</a></li>
            <li><a href="about.html">About</a></li>
            <li><a href="services.html">Services</a></li>
            <li><a href="contact.html">Contact</a></li>
          </ul>
        </div>
      </div>
      <div class="footer-bottom">
        &copy; 2023 Broadway Stores, Inc. 
      </div>
    `;
    document.body.appendChild(footer); // Add footer to the end of the body
  }

  
  // Call the functions to create the header and footer when the window loads
  window.onload = function() {
    createHeader();
    createFooter();
  };
  