
function isDevice() {
	let width = document.body.clientWidth;
	return width < 900;
}


function generateAnimation(height, mousecontrol) {
	try {
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
	} catch (e) {
		location.reload();
	}
}

function generateAnimationHome() {
	let height = document.body.clientHeight;
    generateAnimation(height, true);
}

const resizeObserver = new ResizeObserver((entries) => {
	// Boucle à travers les entrées observées
	for (let entry of entries) {
		// Récupérez les nouvelles dimensions de l'élément
		//resizeObserver.unobserve(document.getElementById("maincontent"));
		/*const { width, height } = entry.contentRect;
		console.log(`Nouvelle taille : largeur = ${width}px, hauteur = ${height}px`);
		generateAnimationAllScreen();*/
	}
});

function generateAnimationAllScreen() {
	let height = document.body.clientHeight;
	let divMainContent = document.getElementById("maincontent");
	//resizeObserver.observe(document.getElementById("cadre"));*/
    let div = document.getElementById("fond");
    div.style.height = divMainContent.clientHeight + "px";
    let h = div.clientHeight;
    //generateAnimation(h, false);
}

function regenerateAnimationAllScreen(height) {
	let div = document.getElementById("fond");
	div.style.height = height + "px";
	let h = div.clientHeight;
	generateAnimation(h, false);
}


async function getCaptchaResponse() {
	const body = new URLSearchParams({
		type_site: "localhost",
		token: grecaptcha.getResponse()
	});
	console.log(body);
	const requestOptions = {
		method: 'POST',
		headers: {
			'Content-Type': 'application/x-www-form-urlencoded',
		},
		body: body.toString(),
	};
	var res = false;
	await fetch("https://www.baivel.com/portfolioApi/verifyCaptcha.php", requestOptions)
		.then(response => {
			if (!response.ok) {
				throw new Error('Network response was not ok');
				//afficher une erreur sur la page
			}
			return response.json()
		})
		.then(data => {
			console.log(data.success);
			res = data.success;
		})
		.catch(err => {
			console.log(err.message);
		});
	return res;
}