
document.querySelectorAll('.like-btn').forEach(button => {
        button.addEventListener('click', () => {
            button.classList.toggle('liked');
            button.textContent = button.classList.contains('liked') ? "❤ Liked" : "👍 Like";
        });
});

document.querySelectorAll('.comment-btn').forEach(button => {
        button.addEventListener('click', () => {
            alert('فتح نافذة التعليقات 🚀');
            console.log("Haiii");
        });
});

