// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.
function searchFunc() {
    let input, filter, ul, li, a, i
    input = document.querySelector('#searchC')
    filter = input.value.toUpperCase();
    ul = document.querySelector('#spisok')
    li = document.getElementsByTagName('li')

    for (i = 0; i < li.length; i++) {
        a = li[i].getElementsByTagName("a")[0]
    if (a.innerHTML.toUpperCase().indexOf(filter) > -1) {
        li[i].style.display = ""
    }
    else {
        document.querySelector('.menu1').style.display = "block";
        document.querySelector('.menu2').style.display = "block";
        document.querySelector('.menu3').style.display = "block";

        li[i].style.display = "none"
    }
    }

}


clickChecker = 0
function load() {
    if (clickChecker == 0) {
    $('#secondComment').load('./images/comment.txt');
    $('#comments').css('height', '330px')
    $('#footer').css('top', '1265px')
    clickChecker = 1
}
    else if (clickChecker == 1) {
    $('#thirdComment').load('./images/anotherComment.txt');
    $('#comments').css('height', '465px')
    $('#footer').css('top', '1398px')
    $('#btn').html('All comments')
}
}
