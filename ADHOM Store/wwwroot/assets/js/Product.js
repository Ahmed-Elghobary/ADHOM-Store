
var swiper = new Swiper(".preducts_slider", {
    loop:true,
    grabeCursor:true,
    spaceBetween: 20,
    navigation: {
        nextEl: '.swiper-button-next',
        prevEl: '.swiper-button-prev',
        },
    breakpoints: {
        640: {
            slidesPerView: 1,
            },
            550: {
                slidesPerView: 2,
            },
            768: {
            slidesPerView: 3,
            },
            1024: {
            slidesPerView: 4,
            },
        },
    });


let count = 0;
let value = document.querySelector('.card_shop .contant .card .count .con')
let butn = document.querySelectorAll('.count .fa-solid')
butn.forEach(function (item){
    item.addEventListener('click', function(e){
        let styles = e.currentTarget.classList
        if(styles.contains('fa-plus')){
            count++
        }
        else if(styles.contains('fa-minus')){
            count--
        }else{
            count=0
        }if(count < 0){
            // value.style.color = 'green'
            count=0
        }
        if(count > 0){
            value.style.color = 'red'
        }
        value.textContent = count
    })
})

