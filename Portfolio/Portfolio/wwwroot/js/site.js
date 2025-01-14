function generateAnimation(height, mousecontrol) {
    let width = document.body.clientWidth;
    document.getElementById("home-background").style.height = height + "px"
    VANTA.NET({
        el: "#home-background",
        mouseControls: mousecontrol,
        touchControls: true,
        gyroControls: false,
        minHeight: height,
        minWidth: 200.00,
        scale: 0.70,
        scaleMobile: 1.00,
        color: 0xffffff,
        backgroundColor: 0x0a0068,
        points: 13.00
    })
}

function generateAnimationHome() {
    let height = window.screen.height;
    generateAnimation(height, true);
}

function generateAnimationAllScreen() {
    let height = window.screen.height;
    let divMainContent = document.getElementById("maincontent");
    let div = document.getElementById("fond");
    div.style.height = divMainContent.clientHeight + "px";
    let h = div.clientHeight;
    generateAnimation(h, false);
}