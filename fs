function init() {
    // for smooth scrolling
    gsap.registerPlugin(ScrollTrigger);
    const locoScroll = new LocomotiveScroll({
        el: document.querySelector(".main"),
        smooth: true,
        lerp:0.1
    });
    locoScroll.on("scroll", ScrollTrigger.update);

    ScrollTrigger.scrollerProxy(".main", {
        scrollTop(value) {
            return arguments.length ? locoScroll.scrollTo(value, 0, 0) : locoScroll.scroll.instance.scroll.y;
        }, // we don't have to define a scrollLeft because we're only scrolling vertically.
        getBoundingClientRect() {
            return { top: 0, left: 0, width: window.innerWidth, height: window.innerHeight };
        },
        pinType: document.querySelector(".main").style.transform ? "transform" : "fixed"
    });
}
init()
var crsr = document.querySelector(".cursor")
var main = document.querySelector(".main")
document.addEventListener("mousemove",function(dets){
    crsr.style.left = dets.x + 20+"px"
    crsr.style.top = dets.y + 20+"px"
})
// PAge 1 h1,h2 effect 

// gsap.from(".page1 h1", {
//   y: 100,
//   rotate: 130,
//   opacity: 0,
//   duration: 2,
// //   ease: Expo.easeIn
// });
// gsap.from(".page1 h2", {
//   y: 0,
//   rotate: -130,
//   opacity: 0,
//   duration: 2,
// //   ease: Expo.easeIn,
// });

// h1 h2 zooming effect
var tl = gsap.timeline({
    scrollTrigger: {
        trigger: ".page1 ",
        scroller: ".main",
        // markers:true,
        start: "top 10 ",
        // end: "top 20",
        scrub: 1
    }
})
tl.to(".page1 h1", {
    x: -200,
}, "anim")
tl.to(".page1 h2", {
    x: 2000
}, "anim")
tl.to(".page1 video", {
    width: "90%"
}, "anim")

var tl2 = gsap.timeline({
    scrollTrigger: {
        trigger: ".page1 h1",
        scroller: ".main",
        // markers:true,
        start: "top -115%",
        end: "top -120%",
        scrub: 3
    }
})
tl2.to(".main", {
    backgroundColor: "#fff",
})

var tl3 = gsap.timeline({
    scrollTrigger: {
        trigger: ".page1 h1",
        scroller: ".main",
        // markers:true,
        start: "top -200%",
        end: "top -300%",
        scrub: 2
    }
})

tl3.to(".main",{
    backgroundColor:"#0F0D0D"
})


var boxes = document.querySelectorAll(".box")
boxes.forEach(function(elem){
    elem.addEventListener("mouseenter",function(){
        var att = elem.getAttribute("data-image")
        crsr.style.width = "470px"
        crsr.style.height = "370px"
        crsr.style.borderRadius = "0"
        crsr.style.backgroundImage = `url(${att})`
    })
    elem.addEventListener("mouseleave",function(){
        elem.style.backgroundColor = "transparent"
        crsr.style.width = "20px"
        crsr.style.height = "20px"
        crsr.style.borderRadius = "50%"
        crsr.style.backgroundImage = `none`
    })
})
var h4 = document.querySelectorAll("#nav h4")
var purple = document.querySelector("#purple")
h4.forEach(function(elem){
    elem.addEventListener("mouseenter",function(){
        purple.style.display = "block"   
        purple.style.opacity = "1"
    })
    elem.addEventListener("mouseleave",function(){
        purple.style.display = "none"   
        purple.style.opacity = "0"
    })
})