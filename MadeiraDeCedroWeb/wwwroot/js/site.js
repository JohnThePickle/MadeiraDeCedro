document.querySelectorAll('.carousel-container').forEach(carousel => {
    let currentSlide = 0;
    const slides = carousel.querySelectorAll('.carousel-slide');
    const totalSlides = slides.length;
    const dots = carousel.querySelectorAll('.dot');

    const updateCarousel = () => {
        slides.forEach((slide, index) => {
            slide.style.transform = `translateX(-${currentSlide * 100}%)`;
        });

        dots.forEach((dot, index) => {
            dot.classList.toggle('active', index === currentSlide);
        });
    };

    carousel.querySelector('.prev').addEventListener('click', () => {
        currentSlide = (currentSlide - 1 + totalSlides) % totalSlides;
        updateCarousel();
    });

    carousel.querySelector('.next').addEventListener('click', () => {
        currentSlide = (currentSlide + 1) % totalSlides;
        updateCarousel();
    });

    dots.forEach((dot, index) => {
        dot.addEventListener('click', () => {
            currentSlide = index;
            updateCarousel();
        });
    });

    updateCarousel(); // Initialize the carousel
});