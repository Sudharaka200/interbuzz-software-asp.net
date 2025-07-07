//logo animation
const strip = document.querySelector('.logo-strip');
let pos = 0;

function animate() {
  pos -= 1; // speed
  if (Math.abs(pos) >= strip.scrollWidth / 2) {
    pos = 0; // reset for loop effect
  }
  strip.style.transform = `translateX(${pos}px)`;
  requestAnimationFrame(animate);
}

// Clone content for smooth looping
strip.innerHTML += strip.innerHTML;

animate();

//satisfaction code



// Enable slider only for mobile


window.addEventListener('load', initSwiper);
window.addEventListener('resize', initSwiper);

//Image Preview
function previewImage(event) {
    const input = event.target;
    const preview = document.getElementById("preview");
    const uploadBox = document.getElementById("uploadBox");

    if (input.files && input.files[0]) {
        const reader = new FileReader();

        reader.onload = function (e) {
            preview.src = e.target.result;
            preview.classList.remove("d-none");
            uploadBox.classList.add("uploaded");
        };

        reader.readAsDataURL(input.files[0]);
    }
}