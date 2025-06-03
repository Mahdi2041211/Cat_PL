    function previewImages(event) {
        const preview = document.getElementById('image-preview');
    preview.innerHTML = '';
    const files = event.target.files;
    if (files) {
        Array.from(files).forEach(file => {
            if (file.type.startsWith('image/')) {
                const reader = new FileReader();
                reader.onload = function (e) {
                    const img = document.createElement('img');
                    img.src = e.target.result;
                    img.title = file.name;
                    img.onclick = function () {
                        openModal(e.target.result);
                    };
                    preview.appendChild(img);
                };
                reader.readAsDataURL(file);
            }
        });
        }
    }

    function openModal(src) {
        const modal = document.getElementById('imgModal');
    const modalImg = document.getElementById('modalImg');
    modalImg.src = src;
    modal.style.display = 'flex';
    }

    document.addEventListener('DOMContentLoaded', function () {
        const modal = document.getElementById('imgModal');
    const closeModal = document.getElementById('closeModal');
    modal.addEventListener('click', function (e) {
            if (e.target === modal || e.target === closeModal) {
        modal.style.display = 'none';
    document.getElementById('modalImg').src = '';
            }
        });

    // Button active color on click
    const submitBtn = document.getElementById('submitBtn');
    submitBtn.addEventListener('mousedown', function () {
        submitBtn.classList.add('active');
        });
    submitBtn.addEventListener('mouseup', function () {
        submitBtn.classList.remove('active');
        });
    submitBtn.addEventListener('mouseleave', function () {
        submitBtn.classList.remove('active');
        });
    });
