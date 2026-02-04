
// Project Filter Functionality
document.addEventListener('DOMContentLoaded', function() {
    // Form Submission
    const contactForm = document.querySelector('form');
    if (contactForm) {
        contactForm.addEventListener('submit', function(e) {
            e.preventDefault();
            
            // Add loading state to submit button
            const submitButton = this.querySelector('button[type="submit"]');
            const originalText = submitButton.innerHTML;
            submitButton.innerHTML = '<span class="spinner-border spinner-border-sm me-2"></span>Gönderiliyor...';
            submitButton.disabled = true;

            // Simulate form submission
            setTimeout(() => {
                alert('Mesajınız başarıyla gönderildi! En kısa sürede size dönüş yapacağız.');
                submitButton.innerHTML = originalText;
                submitButton.disabled = false;
                this.reset();
            }, 2000);
        });
    }

    // Mobile Menu Auto Close
    document.querySelectorAll('.navbar-nav .nav-link').forEach(link => {
        link.addEventListener('click', () => {
            const navbarCollapse = document.querySelector('.navbar-collapse');
            if (navbarCollapse && navbarCollapse.classList.contains('show')) {
                const navbarToggler = document.querySelector('.navbar-toggler');
                if (navbarToggler) {
                    navbarToggler.click();
                }
            }
        });
    });
});

// Page Loading Animation
window.addEventListener('load', function() {
    document.body.classList.add('loaded');
});
