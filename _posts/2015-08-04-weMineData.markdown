---
layout: post 
title: "Scraping and GitSharp, and Spark lines" 
date: 2016-08-07
quote: "If you get pulled over for speeding. Tell them your spouse has diarrhoea. — Phil Dunphy [Phil’s - osophy]"
categories: scraping, auto generating post, gitsharp
---
This page is a daily re-generated post (last re-generated  **8/20/2016 5:03:42 PM**), that shows the movement of prices on the [www.weSellCars.co.za](http://www.wesellcars.co.za) website.

## Why?

This post is a culmination of some side projects playing around with scraping, looking for a way to integrate with git through C# and a challenge to use this blog - which has no back-end or support for any server side scripting to dynamically update a post with the relevant data. I realise that would best be accomplished through making new posts but I opted for an altered post as this is a tech blog, multiple posts would not be appropriate.

# Lessons learned

* [GitSharp](http://www.eqqon.com/index.php/GitSharp) is limited and I needed to grab the project from [github](https://github.com/henon/GitSharp) in order to use it.
    The NuGet package kept on complaining about a **repositoryformatversion** setting in config [Core] that it required, it was present, but still complained. I downloaded the project to debug - and did not encounter it. Apart from that - I could not push - and it seems the project does not have a lot of contribution activity (not criticising, jsut stating, I should probably take this up and contribute especially as I would like to employ git as a file store for an application - levering off the already refined functions - more on that in another post).
* Scraping with Selenium is probably not the best way - rather employ HttpClient.
* Quick easy and painless sparklines [jQuery Sparklines](http://omnipotent.net/jquery.sparkline/#s-about)
* Still no backend just a simple process running on a server that commits to Git gets the job done.

## The List
<ol>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/opel-vivaro-19-cdti-panel-van-7691'> PTA,120 600km,2006 Opel Vivaro 1.9 CDTi... (R49000)</a> <span class="sparklines">58000,58000,49000,49000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/ford-ranchero-8112'> PTA,77 028km,1970 Ford Ranchero (R78000)</a> <span class="sparklines">88000,88000,78000,78000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/opel-corsa-lite-sport-7599'> PTA,142 000km,2003 Opel Corsa Lite Spor... (R33000)</a> <span class="sparklines">36000,36000,33000,33000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/chana-changan-benni-13-lux-8252'> PTA,77 000km,2008 Chana Changan Benni ... (R34000)</a> <span class="sparklines">37000,37000,34000,34000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/tata-indica-14-le-7578'> PTA,20 900km,2015 TATA Indica 1.4 LE (R60000)</a> <span class="sparklines">65000,65000,60000,60000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/crackleback-30hp-7056'> PTA,2015 Crackleback 30HP (R49000)</a> <span class="sparklines">53000,53000,49000,49000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/audi-tt-18t-roadster-7628'> PTA,160 000km,2001 Audi TT 1.8T Roadste... (R61000)</a> <span class="sparklines">65000,65000,61000,61000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/tata-telcoline-20-tdi-dc-7659'> PTA,143 000km,2007 TATA Telcoline 2.0 T... (R46000)</a> <span class="sparklines">49000,49000,46000,46000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/toyota-hilux-2700i-raider-dc-7900'> PTA,140 000km,2004 Toyota Hilux 2700i R... (R96000)</a> <span class="sparklines">102000,102000,96000,96000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/kia-picanto-11-7928'> PTA,91 900km,2011 KIA Picanto 1.1 (R65000)</a> <span class="sparklines">69000,69000,65000,65000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/lexus-is250-6924'> PTA,180 000km,2008 Lexus IS250 (R87000)</a> <span class="sparklines">92000,92000,87000,87000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/range-rover-evoque-20-si4-prestige-7969'> PTA,79 500km,2012 Range Rover Evoque 2... (R368000)</a> <span class="sparklines">388000,388000,368000,368000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/tata-xenon-22-dle-dc-8228'> PTA,75 300km,2012 TATA Xenon 2.2 DLE D... (R94000)</a> <span class="sparklines">99000,99000,94000,94000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/hyundai-i10-125-glsfluid-7827'> PTA,31 900km,2011 Hyundai i10 1.25 GLS... (R94000)</a> <span class="sparklines">99000,99000,94000,94000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/mini-cooper-s-7775'> PTA,77 000km,2006 MINI Cooper S (R99000)</a> <span class="sparklines">104000,104000,99000,99000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/volkswagen-polo-vivo-14-7511'> PTA,36 500km,2011 Volkswagen Polo Vivo... (R99000)</a> <span class="sparklines">104000,104000,99000,99000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/audi-a3-20-tdi-ambition-6535'> PTA,155 000km,2004 Audi A3 2.0 TDi AMBI... (R60000)</a> <span class="sparklines">63000,63000,60000,60000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/porsche-cayenne-diesel-tip-8097'> PTA,59 500km,2013 Porsche Cayenne Dies... (R618000)</a> <span class="sparklines">648000,648000,618000,618000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/bmw-550i-exclusive-at-8067'> PTA,80 500km,2010 BMW 550i Exclusive A... (R322000)</a> <span class="sparklines">337000,337000,322000,322000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/suzuki-alto-10-gl-8015'> PTA,100 000km,2010 Suzuki Alto 1.0 GL (R65000)</a> <span class="sparklines">68000,68000,65000,65000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/opel-corsa-14-essentia-5dr-7904'> PTA,134 000km,2010 Opel Corsa 1.4 Essen... (R65000)</a> <span class="sparklines">68000,68000,65000,65000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/fiat-punto-14-essence-5dr-7789'> PTA,91 254km,2011 Fiat Punto 1.4 Essen... (R65000)</a> <span class="sparklines">68000,68000,65000,65000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/ford-bantam-14-tdci-ac-7582'> PTA,166 369km,2010 Ford Bantam 1.4 TDCi... (R65000)</a> <span class="sparklines">68000,68000,65000,65000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/chevrolet-sonic-16-ls-7968'> PTA,76 000km,2012 Chevrolet Sonic 1.6 ... (R88000)</a> <span class="sparklines">92000,92000,88000,88000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/renault-koleos-25-dynamic-7667'> PTA,153 850km,2009 Renault Koleos 2.5 D... (R88000)</a> <span class="sparklines">92000,92000,88000,88000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/peugeot-107-urban-7592'> PTA,86 500km,2012 Peugeot 107 Urban (R66000)</a> <span class="sparklines">69000,69000,66000,66000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/hyundai-i10-125-glsfluid-at-7980'> PTA,21 500km,2011 Hyundai i10 1.25 GLS... (R90000)</a> <span class="sparklines">94000,94000,90000,90000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/opel-tigra-18-sport-7995'> PTA,106 300km,2006 Opel Tigra 1.8 Sport (R70000)</a> <span class="sparklines">73000,73000,70000,70000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/peugeot-107-urban-7908'> PTA,11 000km,2014 Peugeot 107 Urban (R94000)</a> <span class="sparklines">98000,98000,94000,94000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/nissan-navara-25-dci-dc-6969'> PTA,226 000km,2007 Nissan Navara 2.5 dC... (R94000)</a> <span class="sparklines">98000,98000,94000,94000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/opel-astra-18-sport-5dr-7107'> PTA,177 500km,2007 Opel Astra 1.8 Sport... (R48000)</a> <span class="sparklines">50000,50000,48000,48000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/porsche-cayenne-diesel-tiptronic-7303'> PTA,53 500km,2011 Porsche Cayenne Dies... (R483000)</a> <span class="sparklines">503000,503000,483000,483000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/bmw-x5-xdrive40d-at-8243'> PTA,144 600km,2010 BMW X5 XDrive40D A/T (R266000)</a> <span class="sparklines">277000,277000,266000,266000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/volvo-s40-20i-7696'> PTA,92 500km,2010 Volvo S40 2.0i (R100000)</a> <span class="sparklines">104000,104000,100000,100000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/honda-crv-20-rvsi-6940'> PTA,237 000km,2006 Honda CRV 2.0 RVSi (R75000)</a> <span class="sparklines">78000,78000,75000,75000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/yamaha-ar210-boat-7232'> PTA,2007 Yamaha AR210 Boat (R256000)</a> <span class="sparklines">266000,266000,256000,256000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/hyundai-i20-14-7353'> PTA,140 000km,2010 Hyundai i20 1.4 (R77000)</a> <span class="sparklines">80000,80000,77000,77000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/toyota-corolla-13-professional-7821'> PTA,90 000km,2009 Toyota Corolla 1.3 P... (R104000)</a> <span class="sparklines">108000,108000,104000,104000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/renault-clio-3-16-yahoo-7175'> PTA,96 500km,2012 Renault Clio 3 1.6 Y... (R85000)</a> <span class="sparklines">88000,88000,85000,85000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/nissan-x-trail-22d-7055'> PTA,199 500km,2002 Nissan X-Trail 2.2D (R59000)</a> <span class="sparklines">61000,61000,59000,59000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/nissan-np200-16-ac-6866'> PTA,158 000km,2010 Nissan NP200 1.6 A/C (R63000)</a> <span class="sparklines">65000,65000,63000,63000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/hyundai-i20-14-at-7999'> PTA,77 000km,2010 Hyundai i20 1.4 A/T (R96000)</a> <span class="sparklines">99000,99000,96000,96000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/honda-brio-12-comfort-7919'> PTA,36 400km,2013 Honda Brio 1.2 Comfo... (R96000)</a> <span class="sparklines">99000,99000,96000,96000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/nissan-navara-25-dci-xe-kcab-7620'> PTA,228 000km,2011 Nissan Navara 2.5 DC... (R96000)</a> <span class="sparklines">99000,99000,96000,96000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/porsche-boxster-987-at-hard-top-6587'> PTA,159 000km,2006 Porsche Boxster (987... (R226000)</a> <span class="sparklines">233000,233000,226000,226000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/toyota-hilux-30d4d-raider-4x4-dc-7676'> PTA,61 243km,2014 Toyota Hilux 3.0D4D ... (R358000)</a> <span class="sparklines">368000,368000,358000,358000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/land-rover-evoque-22-sd4-pure-7377'> PTA,21 000km,2015 Land Rover Evoque 2.... (R538000)</a> <span class="sparklines">553000,553000,538000,538000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/bmw-f800-gt-high-spec-7910'> PTA,35 000km,2013 BMW F800 GT High Spe... (R73000)</a> <span class="sparklines">75000,75000,73000,73000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/land-rover-evoque-22d-prestige-6238'> PTA,53 000km,2011 Land Rover Evoque 2.... (R368000)</a> <span class="sparklines">378000,378000,368000,368000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/hyundai-i20-14-7925'> PTA,117 800km,2010 Hyundai i20 1.4 (R76000)</a> <span class="sparklines">78000,78000,76000,76000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/toyota-aygo-10-wild-3dr-7866'> PTA,89 000km,2012 Toyota Aygo 1.0 Wild... (R77000)</a> <span class="sparklines">79000,79000,77000,77000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/mercedes-benz-gla-220-cdi-at-4matic-7566'> PTA,30 000km,2014 Mercedes-Benz GLA 22... (R403000)</a> <span class="sparklines">413000,413000,403000,403000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/volkswagen-polo-vivo-14-5dr-8018'> PTA,86 000km,2010 Volkswagen Polo Vivo... (R83000)</a> <span class="sparklines">85000,85000,83000,83000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/hyundai-i20-14-7947'> PTA,118 000km,2011 Hyundai i20 1.4 (R85000)</a> <span class="sparklines">87000,87000,85000,85000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/volkswagen-polo-vivo-14-3dr-7274'> PTA,90 000km,2010 Volkswagen Polo Vivo... (R87000)</a> <span class="sparklines">89000,89000,87000,87000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/fiat-500-12-7923'> PTA,44 000km,2012 Fiat 500 1.2 (R90000)</a> <span class="sparklines">92000,92000,90000,90000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/toyota-prado-30d-vx-8297'> PTA,335 100km,2001 Toyota Prado 3.0D VX (R92000)</a> <span class="sparklines">94000,94000,92000,92000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/peugeot-207-14-popart-5dr-6798'> PTA,77 000km,2012 Peugeot 207 1.4 Popa... (R94000)</a> <span class="sparklines">96000,96000,94000,94000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/renault-scenic-iii-16-expression-7833'> PTA,147 000km,2011 Renault Scenic III 1... (R97000)</a> <span class="sparklines">99000,99000,97000,97000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/honda-jazz-13-trend-7815'> PTA,65 816km,2014 Honda Jazz 1.3 Trend (R98000)</a> <span class="sparklines">100000,100000,98000,98000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/volkswagen-golf-7-14-tsi-blue-motion-7189'> PTA,50 000km,2015 Volkswagen Golf 7 1.... (R256000)</a> <span class="sparklines">261000,261000,256000,256000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/infinity-22-d-m-q50-5147'> PTA,23 000km,2014 Infinity 2.2 D M Q50 (R287000)</a> <span class="sparklines">292000,292000,287000,287000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/bmw-z4-23i-sdrive-auto-8309'> CPT,99 800km,2011 BMW Z4 2.3i Sdrive A... (R241000)</a> <span class="sparklines">241000,241000,241000,241000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/kia-cerato-20crdi-5dr-8306'> CPT,162 400km,2006 Kia Cerato 2.0crdi 5... (R49000)</a> <span class="sparklines">49000,49000,49000,49000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/toyota-conquest-130-8305'> CPT,83 000km,1999 Toyota Conquest 130 (R32000)</a> <span class="sparklines">32000,32000,32000,32000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/volkswagen-polo-16-tdi-comfortline-8304'> PTA,163 000km,2011 Volkswagen Polo 1.6 ... (R112000)</a> <span class="sparklines">112000,112000,112000,112000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/peugeot-107-urban-8303'> PTA,17 000km,2015 Peugeot 107 Urban (R103000)</a> <span class="sparklines">103000,103000,103000,103000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/bmw-s1000rr-trackbike-8301'> PTA,19 000km,2011 BMW S1000RR Trackbik... (R78000)</a> <span class="sparklines">78000,78000,78000,78000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/ford-bantam-18d-8300'> PTA,155 800km,2003 Ford Bantam 1.8D (R40000)</a> <span class="sparklines">40000,40000,40000,40000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/ford-figo-14-ambiente-8298'> PTA,146 850km,2011 Ford Figo 1.4 Ambien... (R71000)</a> <span class="sparklines">71000,71000,71000,71000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/tata-indica-14-le-8296'> PTA,127 000km,2013 TATA Indica 1.4 LE (R40000)</a> <span class="sparklines">40000,40000,40000,40000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/ford-ranger-25td-hi-trail-extra-cab-8295'> PTA,143 520km,2009 Ford Ranger 2.5TD Hi... (R129000)</a> <span class="sparklines">129000,129000,129000,129000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/hyundai-ix35-20-glpremium-8293'> PTA,119 700km,2011 Hyundai IX35 2.0 GL/... (R160000)</a> <span class="sparklines">160000,160000,160000,160000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/viking-sleep-o-ret-115-hp-mariner-8292'> PTA,2001 Viking Sleep O Ret 1... (R53000)</a> <span class="sparklines">53000,53000,53000,53000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/camp-tech-bosvelder-8291'> PTA,2008 Camp Tech Bosvelder (R36000)</a> <span class="sparklines">36000,36000,36000,36000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/kia-picanto-12-ex-8289'> PTA,106 800km,2012 KIA Picanto 1.2 EX (R89000)</a> <span class="sparklines">89000,89000,89000,89000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/mitsubishi-pajero-sport-32di-d-gls-at-8288'> PTA,144 130km,2009 Mitsubishi Pajero Sp... (R185000)</a> <span class="sparklines">185000,185000,185000,185000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/peugeot-107-urban-8285'> PTA,41 000km,2010 Peugeot 107 Urban (R68000)</a> <span class="sparklines">68000,68000,68000,68000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/mercedes-benz-slk200k-8284'> PTA,84 000km,2006 Mercedes-Benz SLK200... (R145000)</a> <span class="sparklines">145000,145000,145000,145000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/toyota-innova-27-vvti-8seater-8283'> PTA,37 000km,2012 Toyota Innova 2.7 VV... (R175000)</a> <span class="sparklines">175000,175000,175000,175000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/nissan-hardbody-3300i-sel-king-cab-8282'> PTA,481 285km,2006 Nissan Hardbody 3300... (R48000)</a> <span class="sparklines">48000,48000,48000,48000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/yamaha-yz450-off-road-8281'> PTA,2012 Yamaha YZ450 Off-Roa... (R35000)</a> <span class="sparklines">35000,35000,35000,35000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/mercedes-benz-c180-be-estate-8280'> PTA,73 000km,2012 Mercedes-Benz C180 B... (R199000)</a> <span class="sparklines">199000,199000,199000,199000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/opel-astra-16-essentia-5dr-8279'> PTA,134 800km,2011 Opel Astra 1.6 Essen... (R109000)</a> <span class="sparklines">109000,109000,109000,109000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/bmw-320i-at-8278'> PTA,75 600km,2013 BMW 320i A/T (R240000)</a> <span class="sparklines">240000,240000,240000,240000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/bmw-525i-at-e60-8277'> PTA,159 258km,2008 BMW 525i A/T (E60) (R127000)</a> <span class="sparklines">127000,127000,127000,127000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/bmw-x1-sdrive20i-at-8276'> PTA,30 000km,2012 BMW X1 SDrive20i A/T (R261000)</a> <span class="sparklines">261000,261000,261000,261000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/toyota-corolla-13-impact-8275'> PTA,113 087km,2014 Toyota Corolla 1.3 I... (R118000)</a> <span class="sparklines">118000,118000,118000,118000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/toyota-corolla-13-professional-8274'> PTA,93 846km,2013 Toyota Corolla 1.3 P... (R119000)</a> <span class="sparklines">119000,119000,119000,119000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/mitsubishi-outlander-24-at-8272'> PTA,211 000km,2005 Mitsubishi Outlander... (R63000)</a> <span class="sparklines">63000,63000,63000,63000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/porsche-boxster-s-987-convertible-8271'> PTA,117 000km,2005 Porsche Boxster S 98... (R238000)</a> <span class="sparklines">238000,238000,238000,238000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/volkswagen-golf-vi-14-tsi-dsg-cabrio-8270'> PTA,105 670km,2012 Volkswagen Golf VI 1... (R204000)</a> <span class="sparklines">204000,204000,204000,204000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/volkswagen-touran-19tdi-8269'> PTA,160 000km,2008 Volkswagen Touran 1.... (R96000)</a> <span class="sparklines">96000,96000,96000,96000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/land-rover-defender-110-tdi-hard-top-8268'> CPT,382 650km,1998 Land Rover Defender ... (R64000)</a> <span class="sparklines">64000,64000,64000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/mazda-323-130-4dr-8267'> CPT,79 000km,1999 Mazda 323 130 4dr (R39000)</a> <span class="sparklines">39000,39000,39000,39000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/audi-a4-18t-avant-ambition-multitronic-8265'> CPT,157 000km,2010 Audi A4 1.8T Avant A... (R129000)</a> <span class="sparklines">129000,129000,129000,129000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/opel-utility-17dti-8264'> CPT,117 000km,2007 Opel Utility 1.7dti (R83000)</a> <span class="sparklines">83000,83000,83000,83000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/honda-civic-18i-vtec-vxi-at-5dr-8263'> LOW MILEAGE!,CPT,23 500km,2010 Honda Civic 1.8i Vte... (R153000)</a> <span class="sparklines">153000,153000,153000,153000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/mini-cooper-convertible-8262'> CPT,140 200km,2006 Mini Cooper Converti... (R93000)</a> <span class="sparklines">93000,93000,93000,93000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/ford-figo-14-ambiente-8261'> CPT,133 250km,2011 Ford Figo 1.4 Ambien... (R75000)</a> <span class="sparklines">75000,75000,75000,75000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/bmw-328i-auto-convertible-8260'> CPT,203 550km,1997 BMW 328i Auto Conver... (R34000)</a> <span class="sparklines">34000,34000,34000,34000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/chevrolet-utility-14i-club-8259'> CPT,24 430km,2012 Chevrolet Utility 1.... (R104000)</a> <span class="sparklines">104000,104000,104000,104000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/bmw-320i-at-f30-8258'> CPT,77 000km,2013 BMW 320i A/T F30 (R248000)</a> <span class="sparklines">248000,248000,248000,248000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/daihatsu-materia-15-at-8257'> PTA,119 000km,2009 Daihatsu Materia 1.5... (R78000)</a> <span class="sparklines">78000,78000,78000,78000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/chevrolet-utility-14-base-8256'> PTA,59 372km,2013 Chevrolet Utility 1.... (R104000)</a> <span class="sparklines">104000,104000,104000,104000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/ford-bantam-13-ac-8255'> PTA,197 000km,2011 Ford Bantam 1.3 A/C (R69000)</a> <span class="sparklines">69000,69000,69000,69000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/mercedes-benz-clc350-at-8254'> PTA,155 600km,2010 Mercedes-Benz CLC350... (R145000)</a> <span class="sparklines">145000,145000,145000,145000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/daihatsu-charade-classic-8251'> PTA,123 500km,2008 Daihatsu Charade Cla... (R47000)</a> <span class="sparklines">47000,47000,47000,47000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/hyundai-ix35-20-glsexecutive-8250'> PTA,97 500km,2010 Hyundai IX35 2.0 GLS... (R157000)</a> <span class="sparklines">157000,157000,157000,157000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/bmw-335i-at-8249'> PTA,109 000km,2010 BMW 335i A/T (R165000)</a> <span class="sparklines">165000,165000,165000,165000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/suzuki-alto-10-gl-8248'> PTA,91 600km,2012 Suzuki Alto 1.0 GL (R73000)</a> <span class="sparklines">73000,73000,73000,73000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/opel-corsa-utility-17d-8247'> PTA,514 000km,2004 Opel Corsa Utility 1... (R32000)</a> <span class="sparklines">32000,32000,32000,32000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/toyota-etios-15-xs-5dr-8246'> PTA,49 400km,2012 Toyota Etios 1.5 XS ... (R89000)</a> <span class="sparklines">89000,89000,89000,89000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/hyundai-azera-33-v6-8245'> PTA,160 345km,2008 Hyundai Azera 3.3 V6 (R68000)</a> <span class="sparklines">68000,68000,68000,68000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/toyota-etios-15-xs-5dr-8240'> PTA,40 100km,2012 Toyota Etios 1.5 XS ... (R100000)</a> <span class="sparklines">100000,100000,100000,100000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/volkswagen-amarok-20-bitdi-8239'> PTA,172 000km,2011 Volkswagen Amarok 2.... (R200000)</a> <span class="sparklines">200000,200000,200000,200000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/chevrolet-spark-12-l-5dr-8238'> PTA,38 200km,2014 Chevrolet Spark 1.2 ... (R85000)</a> <span class="sparklines">85000,85000,85000,85000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/mercedes-benz-sl500-roadster-8236'> PTA,75 400km,2005 Mercedes-Benz SL500 ... (R273000)</a> <span class="sparklines">273000,273000,273000,273000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/volkswagen-jetta-4-19-tdi-highline-8234'> PTA,163 000km,2004 Volkswagen Jetta 4 1... (R50000)</a> <span class="sparklines">50000,50000,50000,50000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/volvo-c30-t5-at-8229'> PTA,119 000km,2007 Volvo C30 T5 A/T (R83000)</a> <span class="sparklines">83000,83000,83000,83000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/jeep-wrangler-sport-st-8227'> PTA,113 000km,2004 Jeep Wrangler Sport ... (R114000)</a> <span class="sparklines">114000,114000,114000,114000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/mercedes-benz-ml350-at-8226'> PTA,178 000km,2006 Mercedes-Benz ML350 ... (R109000)</a> <span class="sparklines">109000,109000,109000,109000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/honda-brio-12-comfort-8225'> PTA,39 000km,2014 Honda Brio 1.2 Comfo... (R112000)</a> <span class="sparklines">112000,112000,112000,112000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/honda-brio-12-comfort-at-8224'> PTA,17 000km,2014 Honda Brio 1.2 Comfo... (R119000)</a> <span class="sparklines">119000,119000,119000,119000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/mini-cooper-s-8222'> PTA,98 982km,2010 Mini Cooper S (R129000)</a> <span class="sparklines">129000,129000,129000,129000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/nissan-x-trail-20-dci-4x2-8221'> PTA,112 000km,2012 Nissan X-Trail 2.0 D... (R170000)</a> <span class="sparklines">170000,170000,170000,170000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/hyundai-ix35-20-gls-executive-8220'> PTA,170 000km,2011 Hyundai IX35 2.0 GLS... (R167000)</a> <span class="sparklines">167000,167000,167000,167000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/volvo-xc60-20t-powershift-8219'> PTA,118 200km,2011 Volvo XC60 2.0T Powe... (R175000)</a> <span class="sparklines">175000,175000,175000,175000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/mercedes-benz-c180-be-classic-at-8217'> PTA,99 000km,2012 Mercedes-Benz C180 B... (R211000)</a> <span class="sparklines">211000,211000,211000,211000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/toyota-fortuner-30d4d-4x4-at-8216'> PTA,73 000km,2011 Toyota Fortuner 3.0D... (R292000)</a> <span class="sparklines">292000,292000,292000,292000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/mercedes-benz-e350-coupe-8215'> PTA,46 000km,2012 Mercedes-Benz E350 C... (R358000)</a> <span class="sparklines">358000,358000,358000,358000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/mitsubishi-asx-20-5dr-gl-8213'> PTA,83 500km,2013 Mitsubishi ASX 2.0 5... (R170000)</a> <span class="sparklines">170000,170000,170000,170000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/nissan-navara-40-v6-dc-8211'> PTA,141 000km,2008 Nissan Navara 4.0 V6... (R132000)</a> <span class="sparklines">132000,132000,132000,132000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/ford-everest-30-tdci-xlt-8210'> CPT,110 600km,2011 Ford Everest 3.0 TDC... (R150000)</a> <span class="sparklines">150000,150000,150000,150000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/hyundai-ix35-20crdi-gls-exec-8209'> CPT,214 420km,2011 Hyundai IX35 2.0crdi... (R129000)</a> <span class="sparklines">129000,129000,129000,129000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/toyota-etios-15xs-5dr-8208'> CPT,13 200km,2013 Toyota Etios 1.5XS 5... (R109000)</a> <span class="sparklines">109000,109000,109000,109000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/honda-crv-20-comfort-at-awd-8207'> PTA,46 100km,2013 Honda CRV 2.0 Comfor... (R238000)</a> <span class="sparklines">238000,238000,238000,238000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/subaru-forester-25-xt-at-8206'> PTA,102 900km,2010 Subaru Forester 2.5 ... (R129000)</a> <span class="sparklines">129000,129000,129000,129000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/bmw-118i-at-8204'> PTA,106 000km,2009 BMW 118i A/T (R124000)</a> <span class="sparklines">124000,124000,124000,124000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/toyota-camry-200-si-at-8202'> PTA,291 000km,1997 Toyota Camry 200 SI ... (R40000)</a> <span class="sparklines">40000,40000,40000,40000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/hyundai-i20-12-motion-8201'> PTA,72 600km,2013 Hyundai i20 1.2 Moti... (R109000)</a> <span class="sparklines">109000,109000,109000,109000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/ford-figo-14-ambiente-8199'> PTA,33 000km,2013 Ford Figo 1.4 Ambien... (R99000)</a> <span class="sparklines">99000,99000,99000,99000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/renault-sandero-16-united-8196'> PTA,105 700km,2010 Renault Sandero 1.6 ... (R57000)</a> <span class="sparklines">57000,57000,57000,57000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/mercedes-benz-e280-at-8195'> PTA,258 203km,1996 Mercedes-Benz E280 A... (R30000)</a> <span class="sparklines">30000,30000,30000,30000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/toyota-fortuner-30d4d-rb-4x4-8193'> PTA,165 000km,2011 Toyota Fortuner 3.0D... (R241000)</a> <span class="sparklines">241000,241000,241000,241000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/toyota-fortuner-30d4d-rb-4x4-8192'> PTA,94 900km,2011 Toyota Fortuner 3.0D... (R246000)</a> <span class="sparklines">246000,246000,246000,246000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/opel-corsa-lite-14-8190'> PTA,116 000km,2005 Opel Corsa Lite 1.4 (R48000)</a> <span class="sparklines">48000,48000,48000,48000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/subaru-forester-25-xs-premium-at-8189'> PTA,138 000km,2008 Subaru Forester 2.5 ... (R99000)</a> <span class="sparklines">99000,99000,99000,99000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/nissan-micra-12-visia-5dr-8187'> CPT,62 580km,2011 Nissan Micra 1.2 Vis... (R75000)</a> <span class="sparklines">75000,75000,75000,75000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/chevrolet-aveo-15ls-4dr-8186'> CPT,153 000km,2008 Chevrolet Aveo 1.5LS... (R54000)</a> <span class="sparklines">54000,54000,54000,54000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/nissan-np200-16-ac-8185'> CPT,36 600km,2015 Nissan NP200 1.6 A/C (R122000)</a> <span class="sparklines">122000,122000,122000,122000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/suzuki-jimny-13-8184'> CPT,100 650km,2009 Suzuki Jimny 1.3 (R124000)</a> <span class="sparklines">124000,124000,124000,124000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/hyundai-i10-gls-motion-8183'> CPT,79 000km,2012 Hyundai I10 GLS moti... (R79000)</a> <span class="sparklines">79000,79000,79000,79000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/jurgens-ci-sprite-splash-8181'> PTA,2005 Jurgens CI Sprite Sp... (R78000)</a> <span class="sparklines">78000,78000,78000,78000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/opel-corsa-17-dti-8180'> PTA,140 000km,2007 Opel Corsa 1.7 DTi (R77000)</a> <span class="sparklines">77000,77000,77000,77000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/harley-davidson-1200-american-8175'> PTA,20 000km,2012 Harley Davidson 1200... (R68000)</a> <span class="sparklines">68000,68000,68000,68000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/bmw-r1200-gs-abs-8174'> PTA,27 000km,2011 BMW R1200 GS ABS (R129000)</a> <span class="sparklines">129000,129000,129000,129000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/bmw-118i-5dr-at-8172'> PTA,93 000km,2012 BMW 118i 5DR A/T (R145000)</a> <span class="sparklines">145000,145000,145000,145000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/chevrolet-spark-lt-5dr-8171'> PTA,138 800km,2006 Chevrolet Spark LT 5... (R37000)</a> <span class="sparklines">37000,37000,37000,37000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/porsche-boxster-s-8170'> PTA,85 000km,2001 Porsche Boxster S (R199000)</a> <span class="sparklines">199000,199000,199000,199000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/peugeot-207-14-xl-8169'> PTA,136 000km,2009 Peugeot 207 1.4 XL (R44000)</a> <span class="sparklines">44000,44000,44000,44000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/nissan-hardbody-np300-20-swb-8166'> PTA,140 000km,2011 Nissan Hardbody NP30... (R92000)</a> <span class="sparklines">92000,92000,92000,92000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/audi-s3-sportback-8165'> PTA,115 000km,2010 Audi S3 Sportback (R241000)</a> <span class="sparklines">241000,241000,241000,241000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/nissan-micra-12-visia-5dr-8162'> PTA,46 000km,2013 Nissan Micra 1.2 Vis... (R88000)</a> <span class="sparklines">88000,88000,88000,88000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/jurgens-explorer-8161'> PTA,2004 Jurgens Explorer (R109000)</a> <span class="sparklines">109000,109000,109000,109000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/jurgens-gypsey-8160'> PTA,2010 Jurgens Gypsey (R126000)</a> <span class="sparklines">126000,126000,126000,126000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/sprite-scout-caravan-8159'> PTA,2005 Sprite Scout Caravan (R78000)</a> <span class="sparklines">78000,78000,78000,78000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/ford-ranger-22-xls-4x4-dc-8157'> PTA,177 000km,2012 Ford Ranger 2.2 XLS ... (R221000)</a> <span class="sparklines">221000,221000,221000,221000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/bmw-320i-8156'> PTA,66 000km,2012 BMW 320i (R216000)</a> <span class="sparklines">216000,216000,216000,216000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/yamaha-xt-600e-8155'> PTA,23 000km,2002 Yamaha XT 600E (R32000)</a> <span class="sparklines">32000,32000,32000,32000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/tata-indica-14-le-8152'> PTA,66 600km,2009 TATA Indica 1.4 LE (R34000)</a> <span class="sparklines">34000,34000,34000,34000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/bmw-320i-at-8150'> LOW MILEAGE!,CPT,109 000km,2007 BMW 320i A/T (R99000)</a> <span class="sparklines">99000,99000,99000,99000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/toyota-corolla-18i-advance-8149'> CPT,89 900km,2010 Toyota Corolla 1.8i ... (R124000)</a> <span class="sparklines">124000,124000,124000,124000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/vw-polo-16-comfortline-5dr-8148'> CPT,157 050km,2010 VW Polo 1.6 Comfortl... (R115000)</a> <span class="sparklines">115000,115000,115000,115000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/kawazaki-z1000-8146'> CPT,63 000km,2012 Kawazaki Z1000 (R48000)</a> <span class="sparklines">48000,48000,48000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/honda-crv-22-ctdi-8145'> CPT,128 000km,2008 Honda CRV 2.2 CTDI (R129000)</a> <span class="sparklines">129000,129000,129000,129000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/mitsubishi-asx-20-5dr-glx-8143'> CPT,63 000km,2013 Mitsubishi ASX 2.0 5... (R179000)</a> <span class="sparklines">179000,179000,179000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/bmw-120d-at-e87-8141'> CPT,116 000km,2010 BMW 120d A/T E87 (R144000)</a> <span class="sparklines">144000,144000,144000,144000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/vw-polo-gti-14-dsg-8136'> CPT,91 000km,2012 VW Polo GTI 1.4 DSG (R199000)</a> <span class="sparklines">199000,199000,199000,199000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/bmw-x6-40d-xdrive-8135'> CPT,96 000km,2012 BMW X6 4.0d Xdrive (R363000)</a> <span class="sparklines">363000,363000,363000,363000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/bmw-f30-320i-at-8134'> CPT,86 000km,2012 BMW F30 320i A/T (R218000)</a> <span class="sparklines">218000,218000,218000,218000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/suzuki-gsx-150f-8133'> PTA,952km,2015 Suzuki GSX 150F (R31000)</a> <span class="sparklines">31000,31000,31000,31000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/renault-duster-15-dci-dynamique-8132'> PTA,44 995km,2014 Renault Duster 1.5 D... (R175000)</a> <span class="sparklines">175000,175000,175000,175000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/nissan-micra-14-comfort-8131'> PTA,110 000km,2004 Nissan Micra 1.4 Com... (R50000)</a> <span class="sparklines">50000,50000,50000,50000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/mercedes-benz-a170-classic-8130'> PTA,160 605km,2007 Mercedes-Benz A170 C... (R78000)</a> <span class="sparklines">78000,78000,78000,78000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/mercedes-benz-c200-be-classic-at-8128'> PTA,114 000km,2012 Mercedes-Benz C200 B... (R204000)</a> <span class="sparklines">204000,204000,204000,204000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/audi-a4-30-tdi-quattro-ambient-stron-8127'> PTA,136 500km,2011 Audi A4 3.0 TDi Quat... (R197000)</a> <span class="sparklines">197000,197000,197000,197000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/hyundai-i20-12-motion-8124'> PTA,35 035km,2014 Hyundai i20 1.2 Moti... (R124000)</a> <span class="sparklines">124000,124000,124000,124000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/volvo-c30-t5-auto-r-design-8122'> BARGAIN!,CPT,80 000km,2011 Volvo C30 T5 Auto R-... (R150000)</a> <span class="sparklines">150000,150000,150000,150000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/bmw-320i-e90-8121'> PTA,298 657km,2008 BMW 320i (E90) (R63000)</a> <span class="sparklines">63000,63000,63000,63000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/audi-a4-20-b7-8119'> PTA,240 000km,2007 Audi A4 2.0 (B7) (R67000)</a> <span class="sparklines">67000,67000,67000,67000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/volkswagen-chico-14-8118'> PTA,161 000km,2006 Volkswagen Chico 1.4 (R38000)</a> <span class="sparklines">38000,38000,38000,38000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/honda-ballade-150-luxline-at-8117'> PTA,167 143km,1994 Honda Ballade 150 Lu... (R40000)</a> <span class="sparklines">40000,40000,40000,40000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/volkswagen-golf-19-tdi-comfortline-8116'> PTA,175 000km,2009 Volkswagen Golf 1.9 ... (R99000)</a> <span class="sparklines">99000,99000,99000,99000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/ford-figo-14-ambiente-8115'> PTA,130 000km,2011 Ford Figo 1.4 Ambien... (R73000)</a> <span class="sparklines">73000,73000,73000,73000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/volkswagen-eos-20t-fsi-sportline-8113'> PTA,123 000km,2008 Volkswagen Eos 2.0T ... (R129000)</a> <span class="sparklines">129000,129000,129000,129000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/chevrolet-utility-14-ac-8109'> PTA,118 800km,2012 Chevrolet Utility 1.... (R88000)</a> <span class="sparklines">88000,88000,88000,88000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/honda-s2000-8108'> PTA,108 000km,2007 Honda S2000 (R190000)</a> <span class="sparklines">190000,190000,190000,190000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/toyota-86-20-8105'> PTA,48 000km,2012 Toyota 86 2.0 (R206000)</a> <span class="sparklines">206000,206000,206000,206000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/toyota-fortuner-30-d4d-rb-at-8104'> PTA,176 400km,2009 Toyota Fortuner 3.0 ... (R211000)</a> <span class="sparklines">211000,211000,211000,211000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/bmw-120i-3dr-8103'> PTA,114 604km,2011 BMW 120i 3DR (R139000)</a> <span class="sparklines">139000,139000,139000,139000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/toyota-etios-15-xs-8102'> PTA,44 000km,2013 Toyota Etios 1.5 XS (R94000)</a> <span class="sparklines">94000,94000,94000,94000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/kia-rio-16-high-5dr-8101'> PTA,153 000km,2010 KIA Rio 1.6 High 5DR (R78000)</a> <span class="sparklines">78000,78000,78000,78000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/opel-corsa-14-essentia-5dr-8100'> PTA,110 000km,2011 Opel Corsa 1.4 Essen... (R94000)</a> <span class="sparklines">94000,94000,94000,94000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/volkswagen-eos-20t-fsi-sportline-8096'> PTA,151 257km,2008 Volkswagen Eos 2.0T ... (R99000)</a> <span class="sparklines">99000,99000,99000,99000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/ford-bantam-13i-xl-8092'> PTA,157 000km,2012 Ford Bantam 1.3i XL (R83000)</a> <span class="sparklines">83000,83000,83000,83000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/volkswagen-golf-vi-gti-20-gti-8090'> PTA,151 500km,2009 Volkswagen Golf VI G... (R170000)</a> <span class="sparklines">170000,170000,170000,170000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/chevrolet-corsa-utility-14-club-8089'> PTA,108 000km,2010 Chevrolet Corsa Util... (R83000)</a> <span class="sparklines">83000,83000,83000,83000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/volkswagen-golf-vi-gti-20-tsi-8086'> PTA,36 789km,2010 Volkswagen Golf VI G... (R241000)</a> <span class="sparklines">241000,241000,241000,241000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/ford-fiesta-st-16-ecoboost-gdti-8084'> PTA,75 000km,2013 Ford Fiesta ST 1.6 E... (R189000)</a> <span class="sparklines">189000,189000,189000,189000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/fiat-500-l-14-easy-8083'> PTA,28 500km,2014 Fiat 500 L 1.4 Easy (R180000)</a> <span class="sparklines">180000,180000,180000,180000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/hyundai-i20-14-fluid-8081'> PTA,73 500km,2013 Hyundai i20 1.4 Flui... (R92000)</a> <span class="sparklines">92000,92000,92000,92000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/ford-focus-20-tdci-si-dr-8080'> PTA,221 000km,2008 Ford Focus 2.0 TDCi ... (R73000)</a> <span class="sparklines">73000,73000,73000,73000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/fiat-500-14-lounge-8079'> PTA,39 500km,2014 Fiat 500 1.4 Lounge (R130000)</a> <span class="sparklines">130000,130000,130000,130000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/volkswagen-polo-vivo-14-trendline-8078'> PTA,122 000km,2010 Volkswagen Polo Vivo... (R90000)</a> <span class="sparklines">90000,90000,90000,90000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/audi-a3-20-fsi-attraction-8077'> PTA,179 900km,2004 Audi A3 2.0 FSI Attr... (R71000)</a> <span class="sparklines">71000,71000,71000,71000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/volkswagen-polo-16-comfortline-8076'> PTA,10 900km,2014 Volkswagen Polo 1.6 ... (R177000)</a> <span class="sparklines">177000,177000,177000,177000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/toyota-fortuner-40-v6-rb-at-8075'> PTA,69 000km,2012 Toyota Fortuner 4.0 ... (R266000)</a> <span class="sparklines">266000,266000,266000,266000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/hummer-h3-luxury-at-8072'> PTA,138 800km,2007 Hummer H3 Luxury A/T (R170000)</a> <span class="sparklines">170000,170000,170000,170000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/tata-super-ace-14-tcic-dls-8071'> PTA,118 000km,2013 TATA Super Ace 1.4 T... (R70000)</a> <span class="sparklines">70000,70000,70000,70000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/bmw-320d-at-8068'> PTA,96 000km,2012 BMW 320D A/T (R234000)</a> <span class="sparklines">234000,234000,234000,234000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/jeep-compass-20-cvt-ltd-8059'> PTA,94 000km,2012 Jeep Compass 2.0 CVT... (R150000)</a> <span class="sparklines">150000,150000,150000,150000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/volkswagen-polo-vivo-16-trendline-8052'> PTA,152 000km,2012 Volkswagen Polo Vivo... (R83000)</a> <span class="sparklines">83000,83000,83000,83000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/renault-sandero-900t-stepway-8050'> PTA,5 800km,2015 Renault Sandero 900T... (R165000)</a> <span class="sparklines">165000,165000,165000,165000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/mazda-5-20-active-8044'> PTA,169 000km,2008 Mazda 5 2.0 Active (R104000)</a> <span class="sparklines">104000,104000,104000,104000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/volkswagen-polo-vivo-14-5dr-ac-8042'> PTA,156 000km,2011 Volkswagen Polo Vivo... (R81000)</a> <span class="sparklines">81000,81000,81000,81000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/ford-ranger-32-tdci-xlt-4x4-dc-8039'> PTA,52 000km,2012 Ford Ranger 3.2 TDCi... (R307000)</a> <span class="sparklines">307000,307000,307000,307000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/toyota-corolla-quest-16-8038'> PTA,12 500km,2015 Toyota Corolla Quest... (R170000)</a> <span class="sparklines">170000,170000,170000,170000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/volkswagen-amarok-20-bitdi-8036'> PTA,157 800km,2011 Volkswagen Amarok 2.... (R221000)</a> <span class="sparklines">221000,221000,221000,221000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/ford-everest-30-tdci-xlt-8035'> PTA,124 000km,2014 Ford Everest 3.0 TDC... (R191000)</a> <span class="sparklines">191000,191000,191000,191000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/toyota-landcruiser-200-45d-v8-8034'> PTA,79 700km,2014 Toyota Landcruiser 2... (R818000)</a> <span class="sparklines">818000,818000,818000,818000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/nissan-navara-25-dci-se-dc-8030'> PTA,159 900km,2010 Nissan Navara 2.5 DC... (R170000)</a> <span class="sparklines">170000,170000,170000,170000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/bmw-320d-8029'> PTA,62 500km,2011 BMW 320D (R177000)</a> <span class="sparklines">177000,177000,177000,177000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/hyundai-i10-125-gls-8014'> PTA,76 000km,2011 Hyundai i10 1.25 GLS (R83000)</a> <span class="sparklines">83000,83000,83000,83000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/audi-q5-20-tdi-quattro-8013'> PTA,65 000km,2011 Audi Q5 2.0 TDi Quat... (R226000)</a> <span class="sparklines">226000,226000,226000,226000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/toyota-corolla-16-advanced-at-8012'> PTA,129 000km,2010 Toyota Corolla 1.6 A... (R134000)</a> <span class="sparklines">134000,134000,134000,134000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/mercedes-benz-c250-cdi-be-elegance-8006'> PTA,59 300km,2012 Mercedes-Benz C250 C... (R289000)</a> <span class="sparklines">289000,289000,289000,289000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/volkswagen-polo-vivo-16-trendline-8005'> PTA,100 700km,2011 Volkswagen Polo Vivo... (R100000)</a> <span class="sparklines">100000,100000,100000,100000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/jeep-cherokee-25-crd-sport-8001'> PTA,218 000km,2003 Jeep Cherokee 2.5 CR... (R49000)</a> <span class="sparklines">49000,49000,49000,49000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/chevrolet-utility-14-sc-7991'> PTA,160 160km,2012 Chevrolet Utility 1.... (R79000)</a> <span class="sparklines">79000,79000,79000,79000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/mazda-bt-50-drifter-30-crdi-slx-sc-7990'> PTA,138 500km,2011 Mazda BT-50 Drifter ... (R145000)</a> <span class="sparklines">145000,145000,145000,145000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/suzuki-sx4-20-awd-7984'> PTA,117 000km,2012 Suzuki SX4 2.0 AWD (R129000)</a> <span class="sparklines">129000,129000,129000,129000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/volkswagen-polo-vivo-14-7983'> PTA,72 800km,2012 Volkswagen Polo Vivo... (R96000)</a> <span class="sparklines">96000,96000,96000,96000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/hyundai-ix35-20-elite-at-7979'> PTA,47 600km,2014 Hyundai IX35 2.0 Eli... (R289000)</a> <span class="sparklines">289000,289000,289000,289000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/volkswagen-amarok-20-bitdi-highline-7970'> PTA,173 000km,2010 Volkswagen Amarok 2.... (R228000)</a> <span class="sparklines">228000,228000,228000,228000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/land-rover-freelander-ii-22-rd4-hse-7966'> PTA,130 065km,2008 Land Rover Freelande... (R134000)</a> <span class="sparklines">134000,134000,134000,134000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/megelli-250r-7962'> PTA,5 000km,2011 Megelli 250R (R25000)</a> <span class="sparklines">25000,25000,25000,25000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/ford-ranger-32tdci-xlt-4x4-dc-7960'> PTA,61 200km,2014 Ford Ranger 3.2TDCi ... (R329000)</a> <span class="sparklines">329000,329000,329000,329000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/tata-indica-vista-14-7945'> PTA,86 600km,2012 TATA Indica Vista 1.... (R42000)</a> <span class="sparklines">42000,42000,42000,42000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/audi-a1-14t-fsi-attraction-stronic-7944'> PTA,93 600km,2014 Audi A1 1.4T FSI Att... (R177000)</a> <span class="sparklines">177000,177000,177000,177000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/bmw-316i-at-7936'> PTA,27 000km,2013 BMW 316i A/T (R246000)</a> <span class="sparklines">246000,246000,246000,246000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/toyota-corolla-13-impact-7911'> PTA,102 000km,2011 Toyota Corolla 1.3 I... (R122000)</a> <span class="sparklines">122000,122000,122000,122000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/volvo-xc60-t6-geartronic-7898'> PTA,161 000km,2010 Volvo XC60 T6 Geartr... (R152000)</a> <span class="sparklines">152000,152000,152000,152000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/honda-crv-22-crdi-7894'> PTA,73 000km,2009 Honda CRV 2.2 CRDI (R171000)</a> <span class="sparklines">171000,171000,171000,171000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/volkswagen-polo-14-comfortline-7889'> PTA,150 400km,2012 Volkswagen Polo 1.4 ... (R109000)</a> <span class="sparklines">109000,109000,109000,109000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/bmw-520d-at-f10-7886'> PTA,121 000km,2011 BMW 520D A/T (F10) (R219000)</a> <span class="sparklines">219000,219000,219000,219000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/nissan-juke-16-dig-t-tekna-7882'> PTA,32 000km,2012 Nissan Juke 1.6 DIG ... (R185000)</a> <span class="sparklines">185000,185000,185000,185000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/porsche-911-turbo-997-7875'> PTA,50 000km,2006 Porsche 911 Turbo (9... (R968000)</a> <span class="sparklines">968000,968000,968000,968000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/mazda-bt-50-32tdi-sle-fcab-7867'> PTA,140 600km,2013 Mazda BT-50 3.2TDi S... (R202000)</a> <span class="sparklines">202000,202000,202000,202000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/nissan-qashqai-15-dci-acenta-7863'> PTA,50 000km,2014 Nissan Qashqai 1.5 D... (R258000)</a> <span class="sparklines">258000,258000,258000,258000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/mercedes-benz-c180-be-classic-at-7861'> PTA,136 700km,2012 Mercedes-Benz C180 B... (R190000)</a> <span class="sparklines">190000,190000,190000,190000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/toyota-hilux-25-d4d-7854'> PTA,78 000km,2013 Toyota Hilux 2.5 D4D (R256000)</a> <span class="sparklines">256000,256000,256000,256000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/suzuki-jimny-13-7853'> PTA,85 460km,2011 Suzuki Jimny 1.3 (R145000)</a> <span class="sparklines">145000,145000,145000,145000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/hyundai-ix35-20-gls-executive-7852'> PTA,138 000km,2010 Hyundai IX35 2.0 GLS... (R138000)</a> <span class="sparklines">138000,138000,138000,138000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/mini-cooper-7849'> PTA,182 200km,2002 MINI Cooper (R44000)</a> <span class="sparklines">44000,44000,44000,44000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/hyundai-ix35-20-glsexclusive-7842'> PTA,135 000km,2011 Hyundai IX35 2.0 GLS... (R172000)</a> <span class="sparklines">172000,172000,172000,172000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/ford-kuga-16-ecoboost-trend-7834'> PTA,58 000km,2013 Ford Kuga 1.6 Ecoboo... (R261000)</a> <span class="sparklines">261000,261000,261000,261000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/bmw-135i-convertible-at-7832'> PTA,134 000km,2009 BMW 135i Convertible... (R202000)</a> <span class="sparklines">202000,202000,202000,202000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/nissan-x-trail-20-xe-4x2-7830'> PTA,95 000km,2010 Nissan X-Trail 2.0 X... (R149000)</a> <span class="sparklines">149000,149000,149000,149000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/honda-xr-125-l-7820'> PTA,6 650km,2012 Honda XR 125 L (R16000)</a> <span class="sparklines">16000,16000,16000,16000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/toyota-hilux-30-d4d-raider-dc-4x4-at-7806'> PTA,84 914km,2011 Toyota Hilux 3.0 D4D... (R279000)</a> <span class="sparklines">279000,279000,279000,279000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/mazda-bt-50-drifter-25-tdi-sc-7792'> PTA,145 000km,2011 Mazda BT-50 Drifter ... (R134000)</a> <span class="sparklines">134000,134000,134000,134000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/mercedes-benz-clk350-at-7791'> PTA,98 626km,2006 Mercedes-Benz CLK350... (R134000)</a> <span class="sparklines">134000,134000,134000,134000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/honda-cr-z-15-7784'> PTA,56 000km,2010 Honda CR-Z 1.5 (R136000)</a> <span class="sparklines">136000,136000,136000,136000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/mercedes-benz-c200-be-classic-at-7779'> PTA,26 100km,2012 Mercedes-Benz C200 B... (R272000)</a> <span class="sparklines">272000,272000,272000,272000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/mercedes-benz-c180-be-avantgarde-7778'> PTA,65 300km,2014 Mercedes-Benz C180 B... (R261000)</a> <span class="sparklines">261000,261000,261000,261000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/volkswagen-polo-vivo-14-7777'> PTA,94 000km,2014 Volkswagen Polo Vivo... (R99000)</a> <span class="sparklines">99000,99000,99000,99000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/audi-a4-allroad-20-tdi-quattro-stronic-7761'> PTA,61 000km,2014 Audi A4 Allroad 2.0 ... (R322000)</a> <span class="sparklines">322000,322000,322000,322000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/toyota-fortuner-30d4d-4x4-7757'> PTA,80 000km,2013 Toyota Fortuner 3.0D... (R289000)</a> <span class="sparklines">289000,289000,289000,289000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/ford-kuga-16-ecoboost-trend-7749'> PTA,49 400km,2013 Ford Kuga 1.6 Ecoboo... (R241000)</a> <span class="sparklines">241000,241000,241000,241000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/mercedes-benz-c180-be-classic-7741'> PTA,51 000km,2013 Mercedes-Benz C180 B... (R246000)</a> <span class="sparklines">246000,246000,246000,246000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/mini-cooper-s-7739'> PTA,42 000km,2010 MINI Cooper S (R148000)</a> <span class="sparklines">148000,148000,148000,148000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/toyota-fortuner-40-v6-at-4x4-7736'> PTA,137 000km,2011 Toyota Fortuner 4.0 ... (R251000)</a> <span class="sparklines">251000,251000,251000,251000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/nissan-qashqai-20-acenta-7734'> PTA,110 905km,2011 Nissan Qashqai 2.0 A... (R168000)</a> <span class="sparklines">168000,168000,168000,168000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/chevrolet-spark-12-lt-7727'> PTA,22 000km,2013 Chevrolet Spark 1.2 ... (R111000)</a> <span class="sparklines">111000,111000,111000,111000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/honda-cb1000r-7719'> PTA,22 500km,2011 Honda CB1000R (R78000)</a> <span class="sparklines">78000,78000,78000,78000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/hyundai-i20-glide-7717'> PTA,51 600km,2012 Hyundai i20 Glide (R129000)</a> <span class="sparklines">129000,129000,129000,129000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/chevrolet-utility-14-sc-7707'> PTA,53 000km,2015 Chevrolet Utility 1.... (R114000)</a> <span class="sparklines">114000,114000,114000,114000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/volkswagen-kombi-t5-20tdi-trend-75kw-7700'> PTA,91 100km,2012 Volkswagen Kombi T5 ... (R251000)</a> <span class="sparklines">251000,251000,251000,251000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/alfa-romeo-gt-32-v6-distinctive-7683'> PTA,68 000km,2010 Alfa Romeo GT 3.2 V6... (R122000)</a> <span class="sparklines">122000,122000,122000,122000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/toyota-hilux-2700i-raider-rb-dc-7653'> PTA,280 000km,2005 Toyota Hilux 2700i R... (R145000)</a> <span class="sparklines">145000,145000,145000,145000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/bmw-320i-f30-7635'> PTA,85 500km,2012 BMW 320i F30 (R206000)</a> <span class="sparklines">206000,206000,206000,206000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/ford-ranger-32-xls-super-cab-7602'> PTA,145 000km,2012 Ford Ranger 3.2 XLS ... (R204000)</a> <span class="sparklines">204000,204000,204000,204000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/bmw-320i-at-7598'> PTA,29 500km,2014 BMW 320i A/T (R297000)</a> <span class="sparklines">297000,297000,297000,297000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/hyundai-ix35-20-gls-7593'> PTA,139 398km,2011 Hyundai IX35 2.0 GLS (R160000)</a> <span class="sparklines">160000,160000,160000,160000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/toyota-prado-vx-40-v6-at-7589'> PTA,272 000km,2005 Toyota Prado VX 4.0 ... (R145000)</a> <span class="sparklines">145000,145000,145000,145000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/bmw-320i-lux-at-f30-7580'> PTA,110 000km,2012 BMW 320i Lux A/T F30 (R226000)</a> <span class="sparklines">226000,226000,226000,226000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/volkswagen-polo-classic-16-7560'> PTA,117 000km,2009 Volkswagen Polo Clas... (R92000)</a> <span class="sparklines">92000,92000,92000,92000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/mercedes-benz-c200-be-classic-at-7555'> PTA,57 000km,2013 Mercedes-Benz C200 B... (R236000)</a> <span class="sparklines">236000,236000,236000,236000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/nissan-juke-16-acenta-7541'> PTA,27 600km,2011 Nissan Juke 1.6 Acen... (R155000)</a> <span class="sparklines">155000,155000,155000,155000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/bmw-116i-at-5dr-7535'> PTA,65 000km,2013 BMW 116i A/T 5DR (R202000)</a> <span class="sparklines">202000,202000,202000,202000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/volkswagen-polo-vivo-14-classic-trendline-7530'> PTA,29 749km,2014 Volkswagen Polo Vivo... (R134000)</a> <span class="sparklines">134000,134000,134000,134000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/toyota-fortuner-30d4d-at-7524'> PTA,103 000km,2011 Toyota Fortuner 3.0D... (R246000)</a> <span class="sparklines">246000,246000,246000,246000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/toyota-yaris-15-hsd-xr-5dr-hybrid-7519'> PTA,39 000km,2012 Toyota Yaris 1.5 HSD... (R175000)</a> <span class="sparklines">175000,175000,175000,175000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/volkswagen-jetta-vi-16-tdi-7506'> PTA,86 700km,2012 Volkswagen Jetta VI ... (R180000)</a> <span class="sparklines">180000,180000,180000,180000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/fiat-panda-12-pop-7503'> PTA,51 000km,2013 Fiat Panda 1.2 Pop (R90000)</a> <span class="sparklines">90000,90000,90000,90000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/volkswagen-polo-classic-14-trend-7480'> PTA,54 000km,2014 Volkswagen Polo Clas... (R140000)</a> <span class="sparklines">140000,140000,140000,140000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/land-rover-freelander-ii-22d-hse-at-7469'> PTA,164 000km,2008 Land Rover Freelande... (R130000)</a> <span class="sparklines">130000,130000,130000,130000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/kia-picanto-12-ex-7460'> PTA,158 000km,2011 KIA Picanto 1.2 EX (R79000)</a> <span class="sparklines">79000,79000,79000,79000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/chevrolet-commodore-gl-at-7417'> PTA,88 000km,1981 Chevrolet Commodore ... (R17000)</a> <span class="sparklines">17000,17000,17000,17000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/mercedes-benz-c250-be-coupe-at-7412'> PTA,65 000km,2013 Mercedes-Benz C250 B... (R279000)</a> <span class="sparklines">279000,279000,279000,279000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/hyundai-accent-16-glsfluid-7388'> PTA,120 011km,2012 Hyundai Accent 1.6 G... (R106000)</a> <span class="sparklines">106000,106000,106000,106000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/volkswagen-golf-5-gti-20t-fsi-7382'> PTA,183 420km,2006 Volkswagen Golf 5 GT... (R119000)</a> <span class="sparklines">119000,119000,119000,119000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/mercedes-benz-c180-be-classic-at-7349'> PTA,83 000km,2011 Mercedes-Benz C180 B... (R198000)</a> <span class="sparklines">198000,198000,198000,198000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/mini-cooper-s-7332'> PTA,39 000km,2011 Mini Cooper S (R170000)</a> <span class="sparklines">170000,170000,170000,170000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/mitsubishi-asx-20-5dr-glx-7314'> PTA,111 700km,2011 Mitsubishi ASX 2.0 5... (R150000)</a> <span class="sparklines">150000,150000,150000,150000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/bmw-120i-convertible-at-7291'> PTA,123 600km,2010 BMW 120i Convertible... (R169000)</a> <span class="sparklines">169000,169000,169000,169000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/bmw-335i-at-7290'> PTA,116 000km,2010 BMW 335i A/T (R170000)</a> <span class="sparklines">170000,170000,170000,170000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/alfa-romeo-gt-19-jtd-distinctive-7278'> PTA,90 500km,2007 Alfa Romeo GT 1.9 JT... (R88000)</a> <span class="sparklines">88000,88000,88000,88000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/ford-everest-30-tdci-xlt-7275'> PTA,95 000km,2013 Ford Everest 3.0 TDC... (R198000)</a> <span class="sparklines">198000,198000,198000,198000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/mercedes-benz-c180-cgi-be-classic-7256'> PTA,95 000km,2011 Mercedes-Benz C180 C... (R185000)</a> <span class="sparklines">185000,185000,185000,185000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/mercedes-benz-slk350-at-7211'> PTA,118 000km,2005 Mercedes-Benz SLK350... (R165000)</a> <span class="sparklines">165000,165000,165000,165000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/audi-a1-14t-fsi-ambition-s-line-stronic-7208'> PTA,69 000km,2011 Audi A1 1.4T FSI Amb... (R185000)</a> <span class="sparklines">185000,185000,185000,185000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/bmw-320i-at-7206'> PTA,128 000km,2011 BMW 320i A/T (R130000)</a> <span class="sparklines">130000,130000,130000,130000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/mercedes-benz-slk200k-roadster-at-7197'> PTA,132 831km,2005 Mercedes-Benz SLK200... (R134000)</a> <span class="sparklines">134000,134000,134000,134000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/hyundai-i20-16-7190'> PTA,85 500km,2010 Hyundai i20 1.6 (R92000)</a> <span class="sparklines">92000,92000,92000,92000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/hyundai-accent-16-gls-fluid-7182'> PTA,106 700km,2012 Hyundai Accent 1.6 G... (R100000)</a> <span class="sparklines">100000,100000,100000,100000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/mitsubishi-pajero-3200-di-d-5dr-7174'> PTA,132 450km,2001 Mitsubishi Pajero 32... (R94000)</a> <span class="sparklines">94000,94000,94000,94000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/mercedes-benz-c200-classic-be-at-7171'> PTA,41 192km,2013 Mercedes-Benz C200 C... (R261000)</a> <span class="sparklines">261000,261000,261000,261000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/mercedes-benz-c200-be-classic-at-7123'> PTA,78 973km,2012 Mercedes-Benz C200 B... (R229000)</a> <span class="sparklines">229000,229000,229000,229000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/mini-cooper-countryman-7115'> PTA,32 000km,2014 Mini Cooper Countrym... (R266000)</a> <span class="sparklines">266000,266000,266000,266000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/lexus-gs-300-se-at-7099'> PTA,178 000km,2007 Lexus GS 300 SE A/T (R109000)</a> <span class="sparklines">109000,109000,109000,109000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/bmw-320d-e90-7079'> PTA,156 000km,2005 BMW 320D (E90) (R68000)</a> <span class="sparklines">68000,68000,68000,68000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/volkswagen-polo-16-comfortline-7075'> PTA,101 900km,2012 Volkswagen Polo 1.6 ... (R132000)</a> <span class="sparklines">132000,132000,132000,132000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/chery-qq3-08-te-7073'> PTA,152 000km,2010 Chery QQ3 0.8 TE (R29000)</a> <span class="sparklines">29000,29000,29000,29000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/jeep-cherokee-37-sport-at-7072'> PTA,34 000km,2014 Jeep Cherokee 3.7 Sp... (R246000)</a> <span class="sparklines">246000,246000,246000,246000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/jurgens-ci-splash-7057'> PTA,2008 Jurgens CI Splash (R118000)</a> <span class="sparklines">118000,118000,118000,118000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/mercedes-benz-sl500-roadster-7053'> PTA,115 300km,2002 Mercedes-Benz SL500 ... (R165000)</a> <span class="sparklines">165000,165000,165000,165000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/bmw-320d-at-f30-7050'> PTA,86 500km,2012 BMW 320D A/T (F30) (R238000)</a> <span class="sparklines">238000,238000,238000,238000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/hyundai-i30-16-glspremium-7037'> PTA,38 000km,2013 Hyundai i30 1.6 GLS/... (R175000)</a> <span class="sparklines">175000,175000,175000,175000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/hyundai-i20-14-7001'> PTA,127 077km,2010 Hyundai i20 1.4 (R65000)</a> <span class="sparklines">65000,65000,65000,65000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/mini-cooper-6978'> PTA,69 000km,2012 Mini Cooper (R148000)</a> <span class="sparklines">148000,148000,148000,148000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/chevrolet-cruze-18-lt-at-6944'> PTA,135 000km,2010 Chevrolet Cruze 1.8 ... (R99000)</a> <span class="sparklines">99000,99000,99000,99000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/volkswagen-golf-gti-20t-fsi-6934'> PTA,183 000km,2006 Volkswagen Golf GTI ... (R124000)</a> <span class="sparklines">124000,124000,124000,124000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/audi-q7-42-fsi-v8-quattro-tip-6932'> PTA,172 000km,2006 Audi Q7 4.2 FSI V8 Q... (R161000)</a> <span class="sparklines">161000,161000,161000,161000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/bmw-135i-convertible-at-6886'> PTA,103 000km,2010 BMW 135i Convertible... (R216000)</a> <span class="sparklines">216000,216000,216000,216000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/mini-cooper-s-convertible-6858'> PTA,59 000km,2007 Mini Cooper S Conver... (R124000)</a> <span class="sparklines">124000,124000,124000,124000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/kia-sedona-29d-6755'> PTA,114 037km,2007 Kia Sedona 2.9D (R44000)</a> <span class="sparklines">44000,44000,44000,44000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/mercedes-benz-slk350-at-6739'> PTA,155 000km,2005 Mercedes-Benz SLK350... (R150000)</a> <span class="sparklines">150000,150000,150000,150000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/tom-cat-boat-trailer-6718'> PTA,2010 Tom Cat Boat Trailer (R177000)</a> <span class="sparklines">177000,177000,177000,177000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/volkswagen-jetta-16-tdi-comfortline-6657'> PTA,125 000km,2010 Volkswagen Jetta 1.6... (R124000)</a> <span class="sparklines">124000,124000,124000,124000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/chrysler-grand-voyager-le-33-v6-6639'> PTA,157 000km,1999 Chrysler Grand Voyag... (R32000)</a> <span class="sparklines">32000,32000,32000,32000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/porsche-boxster-s-986-6638'> PTA,148 400km,2002 Porsche Boxster S (9... (R180000)</a> <span class="sparklines">180000,180000,180000,180000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/honda-civic-18-elegance-5dr-6631'> PTA,117 000km,2013 Honda Civic 1.8 Eleg... (R145000)</a> <span class="sparklines">145000,145000,145000,145000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/nissan-navara-25-dci-xe-kcab-4x4-pu-6615'> PTA,159 800km,2010 Nissan Navara 2.5 dC... (R124000)</a> <span class="sparklines">124000,124000,124000,124000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/jeep-compass-20-ltd-6592'> PTA,21 055km,2014 Jeep Compass 2.0 LTD (R218000)</a> <span class="sparklines">218000,218000,218000,218000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/mercedes-benz-vito-116-cdi-crew-6510'> PTA,26 100km,2013 Mercedes-Benz Vito 1... (R364000)</a> <span class="sparklines">364000,364000,364000,364000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/chevrolet-captiva-24-lt-6488'> PTA,113 000km,2010 Chevrolet Captiva 2.... (R126000)</a> <span class="sparklines">126000,126000,126000,126000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/jurgens-exclusive-6422'> PTA,2006 Jurgens Exclusive (R130000)</a> <span class="sparklines">130000,130000,130000,130000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/bmw-z4-roadster-30i-at-6373'> PTA,139 700km,2004 BMW Z4 Roadster 3.0i... (R106000)</a> <span class="sparklines">106000,106000,106000,106000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/mitsubishi-asx-20-gl-5dr-6263'> PTA,81 700km,2012 Mitsubishi ASX 2.0 G... (R160000)</a> <span class="sparklines">160000,160000,160000,160000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/mercedes-benz-b180-be-at-6136'> PTA,40 000km,2013 Mercedes-Benz B180 B... (R226000)</a> <span class="sparklines">226000,226000,226000,226000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/mini-cooper-s-convertible-at-6118'> PTA,65 000km,2009 Mini Cooper S Conver... (R136000)</a> <span class="sparklines">136000,136000,136000,136000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/jeep-compass-20-cvt-ltd-6096'> PTA,57 000km,2013 Jeep Compass 2.0 CVT... (R165000)</a> <span class="sparklines">165000,165000,165000,165000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/mini-cooper-conv-16-6049'> PTA,2011 MINI Cooper Conv 1.6 (R134000)</a> <span class="sparklines">134000,134000,134000,134000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/alfa-romeo-giulietta-14t-6048'> PTA,56 200km,2010 Alfa Romeo Giulietta... (R128000)</a> <span class="sparklines">128000,128000,128000,128000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/alfa-romeo-mito-14t-multiair-6035'> PTA,54 000km,2012 Alfa Romeo MiTO 1.4T... (R124000)</a> <span class="sparklines">124000,124000,124000,124000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/chevrolet-captiva-24-lt-4x4-5919'> PTA,174 000km,2008 Chevrolet Captiva 2.... (R99000)</a> <span class="sparklines">99000,99000,99000,99000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/honda-nsc-110cc-scooter-5862'> BARGAIN!,PTA,100km,2013 Honda NSC 110cc Scoo... (R12000)</a> <span class="sparklines">12000,12000,12000,12000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/porsche-boxster-5728'> PTA,69 351km,2006 Porsche Boxster (R277000)</a> <span class="sparklines">277000,277000,277000,277000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/ford-bantam-13i-ac-pu-sc-5677'> PTA,159 000km,2011 Ford Bantam 1.3i A/C... (R69000)</a> <span class="sparklines">69000,69000,69000,69000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/volkswagen-tiguan-14-tsi-trend-5631'> PTA,103 000km,2010 Volkswagen Tiguan 1.... (R155000)</a> <span class="sparklines">155000,155000,155000,155000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/nissan-livina-16-visia-5591'> PTA,55 000km,2013 Nissan Livina 1.6 Vi... (R111000)</a> <span class="sparklines">111000,111000,111000,111000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/volkswagen-amarok-20-bitdi-trendline-5552'> PTA,138 000km,2013 Volkswagen Amarok 2.... (R175000)</a> <span class="sparklines">175000,175000,175000,175000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/land-rover-range-rover-v8-5518'> PTA,134 263km,2003 Land Rover Range Rov... (R104000)</a> <span class="sparklines">104000,104000,104000,104000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/hyundai-h-1-gls-24-cvvt-wagon-5495'> PTA,21 000km,2015 Hyundai H-1 GLS 2.4 ... (R353000)</a> <span class="sparklines">353000,353000,353000,353000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/bmw-x5-xdrive-35d-at-5415'> PTA,133 800km,2010 BMW X5 xDrive 35D A/... (R246000)</a> <span class="sparklines">246000,246000,246000,246000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/bmw-325i-e90-at-5237'> PTA,134 900km,2008 BMW 325i E90 A/T (R109000)</a> <span class="sparklines">109000,109000,109000,109000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/mercedes-benz-e270-cdi-at-5201'> PTA,180 000km,2005 Mercedes-Benz E270 C... (R65000)</a> <span class="sparklines">65000,65000,65000,65000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/mercedes-benz-viano-30-cdi-be-at-trend-5121'> PTA,111 000km,2011 Mercedes-Benz Viano ... (R347000)</a> <span class="sparklines">347000,347000,347000,347000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/porsche-boxster-32-coupe-4787'> PTA,125 700km,2004 Porsche Boxster 3.2 ... (R206000)</a> <span class="sparklines">206000,206000,206000,206000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/toyota-fortuner-40-v6-4x2-rb-4607'> PTA,242 000km,2006 Toyota Fortuner 4.0 ... (R117000)</a> <span class="sparklines">117000,117000,117000,117000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/ford-fiesta-16-tdci-3dr-8350'> PTA,102 000km,2006 Ford Fiesta 1.6 TDCi... (R48000)</a> <span class="sparklines">48000,48000,48000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/toyota-corolla-16-advance-8349'> PTA,204 100km,2008 Toyota Corolla 1.6 A... (R75000)</a> <span class="sparklines">75000,75000,75000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/hyundai-h100-26-8348'> PTA,218 000km,2004 Hyundai H100 2.6 (R78000)</a> <span class="sparklines">78000,78000,78000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/audi-a3-20-tdi-3dr-8347'> PTA,103 000km,2007 Audi A3 2.0 TDI 3DR (R77000)</a> <span class="sparklines">77000,77000,77000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/toyota-corolla-16-advance-at-8343'> PTA,90 600km,2012 Toyota Corolla 1.6 A... (R145000)</a> <span class="sparklines">145000,145000,145000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/suzuki-jimny-13-3dr-8342'> PTA,30 700km,2015 Suzuki Jimny 1.3 3DR (R195000)</a> <span class="sparklines">195000,195000,195000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/hyundai-i20-14-8341'> PTA,116 000km,2010 Hyundai i20 1.4 (R87000)</a> <span class="sparklines">87000,87000,87000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/land-rover-discovery-4-30-tdv6-hse-at-8340'> PTA,179 000km,2010 Land Rover Discovery... (R277000)</a> <span class="sparklines">277000,277000,277000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/renault-megane-iii-16-coupe-8339'> PTA,72 000km,2009 Renault Megane III 1... (R97000)</a> <span class="sparklines">97000,97000,97000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/nissan-juke-16-dig-t-tekna-8338'> PTA,38 000km,2014 Nissan Juke 1.6 DIG-... (R190000)</a> <span class="sparklines">190000,190000,190000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/ford-focus-18-5dr-8336'> PTA,84 390km,2010 Ford Focus 1.8 5DR (R114000)</a> <span class="sparklines">114000,114000,114000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/ford-kuga-16-ecoboost-titanium-awd-at-8335'> PTA,33 000km,2014 Ford Kuga 1.6 Ecoboo... (R312000)</a> <span class="sparklines">312000,312000,312000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/volkswagen-polo-vivo-14-trendline-at-8334'> PTA,43 245km,2013 Volkswagen Polo Vivo... (R119000)</a> <span class="sparklines">119000,119000,119000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/renault-scenic-20-dyn-at-8333'> PTA,147 039km,2004 Renault Scenic 2.0 D... (R44000)</a> <span class="sparklines">44000,44000,44000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/hyundai-i20-14-8332'> PTA,35 850km,2012 Hyundai i20 1.4 (R109000)</a> <span class="sparklines">109000,109000,109000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/toyota-corolla-16-professional-8331'> PTA,558 525km,2008 Toyota Corolla 1.6 P... (R71000)</a> <span class="sparklines">71000,71000,71000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/volkswagen-polo-vivo-16-8330'> PTA,152 000km,2011 Volkswagen Polo Vivo... (R96000)</a> <span class="sparklines">96000,96000,96000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/isuzu-kb320-lx-4x2-8329'> PTA,218 400km,2002 Isuzu KB320 LX 4x2 (R90000)</a> <span class="sparklines">90000,90000,90000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/kia-cerato-16-8328'> PTA,117 000km,2010 KIA Cerato 1.6 (R94000)</a> <span class="sparklines">94000,94000,94000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/volkswagen-jetta-16-trendline-8325'> PTA,268 000km,2007 Volkswagen Jetta 1.6... (R65000)</a> <span class="sparklines">65000,65000,65000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/volvo-s40-24i-at-8323'> PTA,88 103km,2008 Volvo S40 2.4i A/T (R99000)</a> <span class="sparklines">99000,99000,99000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/nissan-np200-16-ac-safety-pack-8322'> PTA,128 800km,2013 Nissan NP200 1.6 A/C... (R89000)</a> <span class="sparklines">89000,89000,89000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/land-rover-freelander-ii-22-td4-8320'> PTA,159 000km,2008 Land Rover Freelande... (R124000)</a> <span class="sparklines">124000,124000,124000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/toyota-yaris-t3-at-8319'> PTA,102 300km,2008 Toyota Yaris T3+ A/T (R83000)</a> <span class="sparklines">83000,83000,83000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/subaru-forester-25-xt-8318'> PTA,193 300km,2004 Subaru Forester 2.5 ... (R55000)</a> <span class="sparklines">55000,55000,55000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/bmw-118i-5dr-at-8316'> PTA,93 200km,2012 BMW 118i 5DR A/T (R197000)</a> <span class="sparklines">197000,197000,197000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/nissan-micra-12-visia-5dr-8314'> PTA,63 900km,2014 Nissan Micra 1.2 Vis... (R71000)</a> <span class="sparklines">71000,71000,71000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/ford-figo-14-ambiente-8312'> PTA,91 300km,2013 Ford Figo 1.4 Ambien... (R87000)</a> <span class="sparklines">87000,87000,87000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/jurgens-palma-caravan-8311'> PTA,2004 Jurgens Palma Carava... (R89000)</a> <span class="sparklines">89000,89000,89000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/yamaha-jetski-8310'> PTA,2006 Yamaha Jetski (R48000)</a> <span class="sparklines">48000,48000,48000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/jurgens-trailer-120xt-8188'> PTA,2013 Jurgens Trailer 120X... (R29000)</a> <span class="sparklines">29000,29000,29000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/hyundai-i20-16-8414'> PTA,115 000km,2010 Hyundai i20 1.6 (R92000)</a> <span class="sparklines">92000,92000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/ez-go-golf-cart-8413'> PTA,2015 EZ-GO Golf Cart (R30000)</a> <span class="sparklines">30000,30000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/renault-scenic-ii-dynamic-19-dci-8412'> PTA,123 400km,2008 Renault Scenic II Dy... (R65000)</a> <span class="sparklines">65000,65000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/audi-a4-20-8411'> PTA,269 700km,2004 Audi A4 2.0 (R38000)</a> <span class="sparklines">38000,38000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/ford-focus-20-tdci-8409'> PTA,149 000km,2008 Ford Focus 2.0 TDCi (R81000)</a> <span class="sparklines">81000,81000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/chevrolet-sonic-14t-rs-5dr-8408'> PTA,53 500km,2015 Chevrolet Sonic 1.4T... (R160000)</a> <span class="sparklines">160000,160000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/chrysler-300c-35-v6-at-8407'> PTA,132 508km,2010 Chrysler 300C 3.5 V6... (R122000)</a> <span class="sparklines">122000,122000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/nissan-hardbody-25-tdi-dc-8406'> PTA,196 500km,2012 Nissan Hardbody 2.5 ... (R94000)</a> <span class="sparklines">94000,94000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/zotye-nomad-ii-hunter-15-8405'> PTA,29 400km,2012 Zotye Nomad II Hunte... (R73000)</a> <span class="sparklines">73000,73000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/volkswagen-polo-16-trendline-5dr-8404'> PTA,159 000km,2010 Volkswagen Polo 1.6 ... (R87000)</a> <span class="sparklines">87000,87000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/dodge-caliber-18-sxt-at-8403'> PTA,207 000km,2007 Dodge Caliber 1.8 SX... (R63000)</a> <span class="sparklines">63000,63000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/ford-focus-16-vct-8402'> PTA,114 000km,2013 Ford Focus 1.6 VCT (R119000)</a> <span class="sparklines">119000,119000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/hyundai-ix35-20-gls-executive-at-8401'> PTA,155 000km,2010 Hyundai IX35 2.0 GLS... (R155000)</a> <span class="sparklines">155000,155000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/nissan-juke-16-dig-t-tekna-8400'> PTA,101 000km,2011 Nissan Juke 1.6 DIG-... (R145000)</a> <span class="sparklines">145000,145000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/toyota-corolla-verso-160-sx-8399'> PTA,82 000km,2005 Toyota Corolla Verso... (R99000)</a> <span class="sparklines">99000,99000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/mercedes-benz-ml-350-at-8398'> PTA,159 000km,2009 Mercedes-Benz ML 350... (R180000)</a> <span class="sparklines">180000,180000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/chrysler-pt-cruiser-20-tour-8397'> PTA,149 000km,2003 Chrysler PT Cruiser ... (R34000)</a> <span class="sparklines">34000,34000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/land-rover-discovery-4-tdv6-30-se-8396'> PTA,86 448km,2013 Land Rover Discovery... (R473000)</a> <span class="sparklines">473000,473000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/volkswagen-polo-16-comfortline-8395'> PTA,119 000km,2006 Volkswagen Polo 1.6 ... (R71000)</a> <span class="sparklines">71000,71000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/toyota-hilux-30-de-sc-8394'> PTA,472 580km,2003 Toyota Hilux 3.0 DE ... (R71000)</a> <span class="sparklines">71000,71000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/audi-q5-30-tdi-stronic-quattro-8393'> PTA,93 450km,2011 Audi Q5 3.0 TDi S/Tr... (R256000)</a> <span class="sparklines">256000,256000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/bmw-523i-at-8392'> PTA,93 580km,2011 BMW 523i A/T (R211000)</a> <span class="sparklines">211000,211000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/renault-sandero-16-united-8391'> PTA,86 000km,2011 Renault Sandero 1.6 ... (R76000)</a> <span class="sparklines">76000,76000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/toyota-yaris-t1-5dr-ac-8390'> PTA,134 500km,2008 Toyota Yaris T1 5DR ... (R71000)</a> <span class="sparklines">71000,71000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/mercedes-benz-c220-cdi-classic-at-8389'> PTA,118 000km,2010 Mercedes-Benz C220 C... (R190000)</a> <span class="sparklines">190000,190000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/honda-jazz-15-8388'> PTA,238 000km,2007 Honda Jazz 1.5 (R59000)</a> <span class="sparklines">59000,59000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/mercedes-benz-slk-350-at-8387'> PTA,39 000km,2004 Mercedes-Benz SLK 35... (R197000)</a> <span class="sparklines">197000,197000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/opel-corsa-160i-3dr-8386'> CPT,231 800km,2000 Opel Corsa 160i 3dr (R30000)</a> <span class="sparklines">30000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/bmw-320i-auto-8385'> CPT,126 300km,2007 BMW 320i Auto (R73000)</a> <span class="sparklines">73000,73000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/vw-kombi-t5-20tdi-75kw-basetrend-8384'> CPT,118 730km,2012 VW Kombi T5 2.0tdi 7... (R256000)</a> <span class="sparklines">256000,256000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/renault-clio-iii-13-dynamic-8383'> PTA,29 000km,2010 Renault Clio III 1.3... (R99000)</a> <span class="sparklines">99000,99000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/peugeot-206-14-popart-ac-8382'> LOW MILEAGE!,CPT,51 000km,2006 Peugeot 206 1.4 Popa... (R50000)</a> <span class="sparklines">50000,50000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/bmw-320i-e90-8381'> CPT,142 800km,2007 BMW 320i E90 (R83000)</a> <span class="sparklines">83000,83000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/ford-fiesta-14i-5dr-8380'> CPT,129 200km,2007 Ford Fiesta 1.4i 5dr (R55000)</a> <span class="sparklines">55000,55000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/mercedes-benz-cla-200-auto-8379'> CPT,38 500km,2015 Mercedes Benz CLA 20... (R337000)</a> <span class="sparklines">337000,337000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/jeep-cherokee-37-renegade-8378'> CPT,247 000km,2004 Jeep Cherokee 3.7 Re... (R62000)</a> <span class="sparklines">62000,62000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/volvo-s40-t5-at-8377'> PTA,131 600km,2008 Volvo S40 T5 A/T (R94000)</a> <span class="sparklines">94000,94000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/land-rover-discovery-3-tdv6-8375'> PTA,179 500km,2008 Land Rover Discovery... (R145000)</a> <span class="sparklines">145000,145000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/mercedes-benz-a160-classic-8374'> PTA,180 000km,2000 Mercedes-Benz A160 C... (R42000)</a> <span class="sparklines">42000,42000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/proton-savvy-12-at-8373'> PTA,75 000km,2009 Proton Savvy 1.2 A/T (R38000)</a> <span class="sparklines">38000,38000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/chevrolet-spark-pronto-12-8372'> PTA,67 600km,2013 Chevrolet Spark Pron... (R58000)</a> <span class="sparklines">58000,58000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/renault-logan-16-expression-8370'> PTA,176 000km,2010 Renault Logan 1.6 Ex... (R45000)</a> <span class="sparklines">45000,45000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/toyota-fortuner-40-v6-4x4-8369'> PTA,298 000km,2007 Toyota Fortuner 4.0 ... (R114000)</a> <span class="sparklines">114000,114000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/ford-figo-14-tdci-8367'> PTA,117 000km,2011 Ford Figo 1.4 TDCi (R73000)</a> <span class="sparklines">73000,73000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/ford-figo-14-ambiente-8366'> PTA,66 000km,2012 Ford Figo 1.4 Ambien... (R83000)</a> <span class="sparklines">83000,83000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/nissan-np200-16-8365'> PTA,85 000km,2013 Nissan NP200 1.6 (R85000)</a> <span class="sparklines">85000,85000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/alfa-romeo-mito-14-8364'> PTA,92 000km,2009 Alfa Romeo Mito 1.4 (R102000)</a> <span class="sparklines">102000,102000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/bmw-z4-roadster-30-at-8363'> PTA,219 140km,2004 BMW Z4 Roadster 3.0 ... (R73000)</a> <span class="sparklines">73000,73000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/hyundai-getz-16-at-8362'> PTA,120 500km,2008 Hyundai Getz 1.6 A/T (R71000)</a> <span class="sparklines">71000,71000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/toyota-etios-15-xs-5dr-8361'> PTA,49 800km,2012 Toyota Etios 1.5 XS ... (R99000)</a> <span class="sparklines">99000,99000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/ford-focus-20-tdci-ghia-8359'> PTA,134 000km,2007 Ford Focus 2.0 TDCi ... (R69000)</a> <span class="sparklines">69000,69000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/ford-ranger-32-tdci-xls-at-8358'> PTA,63 000km,2014 Ford Ranger 3.2 TDCi... (R297000)</a> <span class="sparklines">297000,297000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/chevrolet-utility-14-ac-8357'> PTA,130 000km,2012 Chevrolet Utility 1.... (R94000)</a> <span class="sparklines">94000,94000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/fiat-uno-mia-1100-3dr-8356'> PTA,108 700km,2001 Fiat Uno Mia 1100 3D... (R23000)</a> <span class="sparklines">23000,23000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/audi-a3-sportback-20-fsi-ttronic-8355'> PTA,166 960km,2007 Audi A3 Sportback 2.... (R86000)</a> <span class="sparklines">86000,86000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/suzuki-jimny-13-8354'> PTA,56 000km,2010 Suzuki Jimny 1.3 (R139000)</a> <span class="sparklines">139000,139000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/daewoo-matiz-08-s-8353'> PTA,195 000km,2001 Daewoo Matiz 0.8 S (R23000)</a> <span class="sparklines">23000,23000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/fiat-uno-fire-3dr-8352'> PTA,245 000km,1997 Fiat Uno Fire 3DR (R9000)</a> <span class="sparklines">9000,9000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/harley-davidson-883-hugger-8351'> PTA,22 154km,2003 Harley Davidson 883 ... (R47000)</a> <span class="sparklines">47000,47000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/ford-figo-14-trend-8025'> PTA,102 000km,2011 Ford Figo 1.4 Trend (R78000)</a> <span class="sparklines">78000,78000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/ford-figo-14-ambiente-7881'> PTA,45 000km,2013 Ford Figo 1.4 Ambien... (R80000)</a> <span class="sparklines">80000,80000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/hyundai-getz-16-hs-4976'> PTA,163 709km,2008 Hyundai Getz 1.6 HS (R58000)</a> <span class="sparklines">58000,58000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/hyundai-i10-gls-motion-8417'> CPT,64 850km,2013 Hyundai I10 GLS Moti... (R85000)</a> <span class="sparklines">85000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/peugeot-307-xr-estate-8416'> CPT,243 900km,2004 Peugeot 307 XR Estat... (R34000)</a> <span class="sparklines">34000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/audi-s3-s-tronic-206kw-8415'> MANAGER'S CHOICE!,CPT,28 200km,2014 Audi S3 S-tronic 206... (R418000)</a> <span class="sparklines">418000</span></div></li>
<li><div><a Href='http://www.wesellcars.co.za/vehicle/ford-ka-8299'> PTA,150 000km,2006 Ford KA (R38000)</a> <span class="sparklines">36000,38000,38000,38000</span></div></li>
</ol>
<script type="text/javascript"> $('.sparklines').sparkline('html'); </script>


