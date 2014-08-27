var likeUnlikeButton = document.getElementById('like-button');
likeUnlikeButton.addEventListener('click', function () {
    if (likeUnlikeButton.innerText === 'Like') {
        likeUnlikeButton.innerText = 'Unlike';
    }
    else {
        likeUnlikeButton.innerText = 'Like';
    }
});