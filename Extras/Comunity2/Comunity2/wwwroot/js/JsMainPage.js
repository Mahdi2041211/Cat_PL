    function showModal(src) {
        document.getElementById('modalImg').src = src;
    document.getElementById('imgModal').classList.add('active');
        }
    function closeModal() {
        document.getElementById('imgModal').classList.remove('active');
    document.getElementById('modalImg').src = '';
        }
    function toggleLike(btn) {
        btn.classList.toggle('liked');
    let icon = btn.querySelector('i');
    let countSpan = btn.querySelector('span');
    let count = parseInt(countSpan.textContent);
    if (btn.classList.contains('liked')) {
        icon.classList.remove('far');
    icon.classList.add('fas');
    countSpan.textContent = count + 1;
            } else {
        icon.classList.remove('fas');
    icon.classList.add('far');
    countSpan.textContent = count - 1;
            }
        }
    function toggleComments(postId, btn) {
        let comments = document.getElementById('comments-' + postId);
    if (comments.style.display === 'none' || comments.style.display === '') {
        comments.style.display = 'block';
    btn.classList.add('liked');
            } else {
        comments.style.display = 'none';
    btn.classList.remove('liked');
            }
        }
    function toggleCommentLike(btn) {
        btn.classList.toggle('liked');
    let icon = btn.querySelector('i');
    let countSpan = btn.querySelector('span');
    let count = parseInt(countSpan.textContent);
    if (btn.classList.contains('liked')) {
        icon.classList.remove('far');
    icon.classList.add('fas');
    countSpan.textContent = count + 1;
            } else {
        icon.classList.remove('fas');
    icon.classList.add('far');
    countSpan.textContent = count - 1;
            }
        }
    function addComment(postId) {
        let input = document.getElementById('add-comment-input-' + postId);
    let text = input.value.trim();
    if (!text) return;
    let commentsDiv = document.getElementById('comments-' + postId);
    let newId = Date.now();
    let commentHtml = `<div class="comment" id="comment-${postId}-${newId}">
        <div class="comment-content"><b>أنت:</b> ${text}</div>
        <div class="comment-actions">
            <button class="comment-like-btn" onclick="toggleCommentLike(this)">
                <i class="far fa-heart"></i>
                <span>0</span>
            </button>
        </div>
    </div>`;
    let addCommentDiv = commentsDiv.querySelector('.add-comment');
    addCommentDiv.insertAdjacentHTML('beforebegin', commentHtml);
    input.value = '';
        }
    // Prevent modal close on image click
    document.getElementById('modalImg').onclick = function (e) {e.stopPropagation(); };
