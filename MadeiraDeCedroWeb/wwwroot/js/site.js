let currentSlide = 0;
const slides = document.querySelectorAll('.carousel-slide');
const totalSlides = slides.length;
const dots = document.querySelectorAll('.dot');

// Set up event listeners for buttons
document.querySelector('.prev').addEventListener('click', () => {
    currentSlide = (currentSlide - 1 + totalSlides) % totalSlides;
    updateCarousel();
});

document.querySelector('.next').addEventListener('click', () => {
    currentSlide = (currentSlide + 1) % totalSlides;
    updateCarousel();
});

// Set up event listeners for dots
dots.forEach((dot, index) => {
    dot.addEventListener('click', () => {
        currentSlide = index;
        updateCarousel();
    });
});

function updateCarousel() {
    slides.forEach((slide, index) => {
        slide.style.transform = `translateX(-${currentSlide * 100}%)`;
    });

    // Update dots
    dots.forEach((dot, index) => {
        if (index === currentSlide) {
            dot.classList.add('active');
        } else {
            dot.classList.remove('active');
        }
    });
}

// Initialize the carousel
updateCarousel();