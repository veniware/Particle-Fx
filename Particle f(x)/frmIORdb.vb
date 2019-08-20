Public Class frmIORdb

    Structure IORitem
        Dim name As String
        Dim index As Decimal
    End Structure

    Public db(300) As IORitem
    Dim dbLength As Integer = 0
    Public Sub New()
        InitializeComponent()

        Dim i As Integer = 0
        db(i).name = "Acetone" : db(i).index = 1.36 : i += 1
        db(i).name = "Actinolite" : db(i).index = 1.618 : i += 1
        db(i).name = "Agalmatoite" : db(i).index = 1.55 : i += 1
        db(i).name = "Agate" : db(i).index = 1.544 : i += 1
        db(i).name = "Agate, moss" : db(i).index = 1.54 : i += 1
        db(i).name = "Air" : db(i).index = 1.0002926 : i += 1
        db(i).name = "Alcohol, ethyl, grain" : db(i).index = 1.36 : i += 1
        db(i).name = "Alcohol, methyl, wood" : db(i).index = 1.329 : i += 1
        db(i).name = "Alexandrite" : db(i).index = 1.745 : i += 1
        db(i).name = "Aluminum" : db(i).index = 1.44 : i += 1
        db(i).name = "Amber" : db(i).index = 1.546 : i += 1
        db(i).name = "Amblygonite" : db(i).index = 1.611 : i += 1
        db(i).name = "Amethyst" : db(i).index = 1.544 : i += 1
        db(i).name = "Anatase" : db(i).index = 2.49 : i += 1
        db(i).name = "Andalusite" : db(i).index = 1.641 : i += 1
        db(i).name = "Anhydrite" : db(i).index = 1.571 : i += 1
        db(i).name = "Apatite" : db(i).index = 1.632 : i += 1
        db(i).name = "Apophyllite" : db(i).index = 1.536 : i += 1
        db(i).name = "Aquamarine" : db(i).index = 1.577 : i += 1
        db(i).name = "Aragonite" : db(i).index = 1.53 : i += 1
        db(i).name = "Argon" : db(i).index = 1.000281 : i += 1
        db(i).name = "Asphalt" : db(i).index = 1.635 : i += 1
        db(i).name = "Augelite" : db(i).index = 1.574 : i += 1
        db(i).name = "Axinite" : db(i).index = 1.675 : i += 1
        db(i).name = "Azurite" : db(i).index = 1.73 : i += 1

        db(i).name = "Barite" : db(i).index = 1.636 : i += 1
        db(i).name = "Barytocalcite" : db(i).index = 1.684 : i += 1
        db(i).name = "Beer" : db(i).index = 1.345 : i += 1
        db(i).name = "Benitoite" : db(i).index = 1.757 : i += 1
        db(i).name = "Benzene" : db(i).index = 1.501 : i += 1
        db(i).name = "Beryl" : db(i).index = 1.577 : i += 1
        db(i).name = "Beryllonite" : db(i).index = 1.553 : i += 1
        db(i).name = "Brazilianite" : db(i).index = 1.603 : i += 1
        db(i).name = "Bromine, liq" : db(i).index = 1.661 : i += 1
        db(i).name = "Bronze" : db(i).index = 1.18 : i += 1
        db(i).name = "Brownite" : db(i).index = 1.567 : i += 1

        db(i).name = "Calcite" : db(i).index = 1.486 : i += 1
        db(i).name = "Calspar" : db(i).index = 1.486 : i += 1
        db(i).name = "Cancrinite" : db(i).index = 1.491 : i += 1
        db(i).name = "Carbon dioxide, gas" : db(i).index = 1.000449 : i += 1
        db(i).name = "Carbon disulfide" : db(i).index = 1.628 : i += 1
        db(i).name = "Carbon Tetrachloride" : db(i).index = 1.461 : i += 1
        db(i).name = "Cassiterite" : db(i).index = 1.997 : i += 1
        db(i).name = "Crysoberyl, catseye" : db(i).index = 1.75 : i += 1
        db(i).name = "Celestite" : db(i).index = 1.622 : i += 1
        db(i).name = "Cerussite" : db(i).index = 1.804 : i += 1
        db(i).name = "Ceylanite" : db(i).index = 1.77 : i += 1
        db(i).name = "Chalcedony" : db(i).index = 1.53 : i += 1
        db(i).name = "Chalk" : db(i).index = 1.51 : i += 1
        db(i).name = "Chalybite" : db(i).index = 1.63 : i += 1
        db(i).name = "Chlorine, gas" : db(i).index = 1.000768 : i += 1
        db(i).name = "Chlorine, liq" : db(i).index = 1.385 : i += 1
        db(i).name = "Chrome green" : db(i).index = 2.4 : i += 1
        db(i).name = "Chrome red" : db(i).index = 2.42 : i += 1
        db(i).name = "Chrome yellow" : db(i).index = 2.31 : i += 1
        db(i).name = "Chromium" : db(i).index = 2.97 : i += 1
        db(i).name = "Chrysoberyl" : db(i).index = 1.745 : i += 1
        db(i).name = "Chrysocolla" : db(i).index = 1.5 : i += 1
        db(i).name = "Chrysoprase" : db(i).index = 1.534 : i += 1
        db(i).name = "Citrine" : db(i).index = 1.55 : i += 1
        db(i).name = "Clinohumite" : db(i).index = 1.65 : i += 1
        db(i).name = "Clinozoisite" : db(i).index = 1.724 : i += 1
        db(i).name = "Cobalt blue" : db(i).index = 1.74 : i += 1
        db(i).name = "Cobalt green" : db(i).index = 1.97 : i += 1
        db(i).name = "Cobalt violet" : db(i).index = 1.71 : i += 1
        db(i).name = "Colemanite" : db(i).index = 1.586 : i += 1
        db(i).name = "Copper" : db(i).index = 1.1 : i += 1
        db(i).name = "Copper oxide" : db(i).index = 2.705 : i += 1
        db(i).name = "Coral" : db(i).index = 1.486 : i += 1
        db(i).name = "Cordierite" : db(i).index = 1.54 : i += 1
        db(i).name = "Corundum" : db(i).index = 1.766 : i += 1
        db(i).name = "Crocoite" : db(i).index = 2.31 : i += 1
        db(i).name = "Crystal" : db(i).index = 2 : i += 1
        db(i).name = "Cuprite" : db(i).index = 2.85 : i += 1

        db(i).name = "Danburite" : db(i).index = 1.633 : i += 1
        db(i).name = "Diamond" : db(i).index = 2.417 : i += 1
        db(i).name = "Diopside" : db(i).index = 1.68 : i += 1
        db(i).name = "Dolomite" : db(i).index = 1.503 : i += 1
        db(i).name = "Dumortierite" : db(i).index = 1.686 : i += 1

        db(i).name = "Ebonite" : db(i).index = 1.66 : i += 1
        db(i).name = "Ekanite" : db(i).index = 1.6 : i += 1
        db(i).name = "Elaeolite" : db(i).index = 1.532 : i += 1
        db(i).name = "Emerald" : db(i).index = 1.576 : i += 1
        db(i).name = "Emerald, synth flux" : db(i).index = 1.561 : i += 1
        db(i).name = "Emerald, synth hydro" : db(i).index = 1.568 : i += 1
        db(i).name = "Enstatite" : db(i).index = 1.663 : i += 1
        db(i).name = "Epidote" : db(i).index = 1.733 : i += 1
        db(i).name = "Ethanol" : db(i).index = 1.36 : i += 1
        db(i).name = "Euclase" : db(i).index = 1.652 : i += 1

        db(i).name = "Fabulite" : db(i).index = 2.409 : i += 1
        db(i).name = "Feldspar, adventurine" : db(i).index = 1.532 : i += 1
        db(i).name = "Feldspar, albite" : db(i).index = 1.525 : i += 1
        db(i).name = "Feldspar, amazonite" : db(i).index = 1.525 : i += 1
        db(i).name = "Feldspar, labradorite" : db(i).index = 1.565 : i += 1
        db(i).name = "Feldspar, microcline" : db(i).index = 1.525 : i += 1
        db(i).name = "Feldspar, oligoclase" : db(i).index = 1.539 : i += 1
        db(i).name = "Feldspar, orthoclase" : db(i).index = 1.525 : i += 1
        db(i).name = "Flour" : db(i).index = 1.434 : i += 1
        db(i).name = "Fluoride" : db(i).index = 1.56 : i += 1
        db(i).name = "Fluorite" : db(i).index = 1.434 : i += 1
        db(i).name = "Formica" : db(i).index = 1.47 : i += 1
        db(i).name = "Fused silica" : db(i).index = 1.4584 : i += 1

        db(i).name = "Garnet, almandine" : db(i).index = 1.76 : i += 1
        db(i).name = "Garnet, almandite" : db(i).index = 1.79 : i += 1
        db(i).name = "Garnet, andradite" : db(i).index = 1.82 : i += 1
        db(i).name = "Garnet, demantoid" : db(i).index = 1.88 : i += 1
        db(i).name = "Garnet, grossular" : db(i).index = 1.738 : i += 1
        db(i).name = "Garnet, hessonite" : db(i).index = 1.745 : i += 1
        db(i).name = "Garnet, rhodolite" : db(i).index = 1.76 : i += 1
        db(i).name = "Garnet, spessartite" : db(i).index = 1.81 : i += 1
        db(i).name = "Gaylussite" : db(i).index = 1.517 : i += 1
        db(i).name = "Glass, albite" : db(i).index = 1.489 : i += 1
        db(i).name = "Glass, crown" : db(i).index = 1.52 : i += 1
        db(i).name = "Glass, crown, zinc" : db(i).index = 1.517 : i += 1
        db(i).name = "Glass, flint, dense" : db(i).index = 1.66 : i += 1
        db(i).name = "Glass, flint, heaviest" : db(i).index = 1.89 : i += 1
        db(i).name = "Glass, flint, heavy" : db(i).index = 1.65548 : i += 1
        db(i).name = "Glass, flint, lanthanum" : db(i).index = 1.8 : i += 1
        db(i).name = "Glass, flint, light" : db(i).index = 1.58038 : i += 1
        db(i).name = "Glass, flint, medium" : db(i).index = 1.62725 : i += 1
        db(i).name = "Glycerine" : db(i).index = 1.473 : i += 1
        db(i).name = "Gold" : db(i).index = 0.47 : i += 1

        db(i).name = "Hambergite" : db(i).index = 1.559 : i += 1
        db(i).name = "Hauynite" : db(i).index = 1.502 : i += 1
        db(i).name = "Helium" : db(i).index = 1.000036 : i += 1
        db(i).name = "Hematite" : db(i).index = 2.94 : i += 1
        db(i).name = "Hemimorphite" : db(i).index = 1.614 : i += 1
        db(i).name = "Hiddenite" : db(i).index = 1.655 : i += 1
        db(i).name = "Honey, 13% water content" : db(i).index = 1.504 : i += 1
        db(i).name = "Honey, 17% water content" : db(i).index = 1.494 : i += 1
        db(i).name = "Honey, 21% water content" : db(i).index = 1.484 : i += 1
        db(i).name = "Howlite" : db(i).index = 1.586 : i += 1
        db(i).name = "Hydrogen, gas" : db(i).index = 1.00014 : i += 1
        db(i).name = "Hydrogen, liq" : db(i).index = 1.0974 : i += 1
        db(i).name = "Hypersthene" : db(i).index = 1.67 : i += 1

        db(i).name = "Idocrase" : db(i).index = 1.713 : i += 1
        db(i).name = "Iodine crystal" : db(i).index = 3.34 : i += 1
        db(i).name = "Iolite" : db(i).index = 1.548 : i += 1
        db(i).name = "Iron" : db(i).index = 1.51 : i += 1
        db(i).name = "Ivory" : db(i).index = 1.54 : i += 1

        db(i).name = "Jade, nephrite" : db(i).index = 1.61 : i += 1
        db(i).name = "Jadeite" : db(i).index = 1.665 : i += 1
        db(i).name = "Jasper" : db(i).index = 1.54 : i += 1
        db(i).name = "Jet" : db(i).index = 1.66 : i += 1

        db(i).name = "Kunzite" : db(i).index = 1.655 : i += 1
        db(i).name = "Kyanite" : db(i).index = 1.715 : i += 1

        db(i).name = "Lapis gem" : db(i).index = 1.5 : i += 1
        db(i).name = "Lapis lazuli" : db(i).index = 1.61 : i += 1
        db(i).name = "Lazulite" : db(i).index = 1.615 : i += 1
        db(i).name = "Lead" : db(i).index = 2.01 : i += 1
        db(i).name = "Leucite" : db(i).index = 1.509 : i += 1

        db(i).name = "Magnesite" : db(i).index = 1.515 : i += 1
        db(i).name = "Malachite" : db(i).index = 1.655 : i += 1
        db(i).name = "Meerschaum" : db(i).index = 1.53 : i += 1
        db(i).name = "Mercury, liq" : db(i).index = 1.62 : i += 1
        db(i).name = "Methanol" : db(i).index = 1.329 : i += 1
        db(i).name = "Methylene iodidel" : db(i).index = 1.74 : i += 1
        db(i).name = "Milk" : db(i).index = 1.35 : i += 1
        db(i).name = "Moldavite" : db(i).index = 1.5 : i += 1
        db(i).name = "Moonstone, adularia" : db(i).index = 1.525 : i += 1
        db(i).name = "Moonstone, albite" : db(i).index = 1.535 : i += 1
        db(i).name = "Mylar" : db(i).index = 1.65 : i += 1

        db(i).name = "Natrolite" : db(i).index = 1.48 : i += 1
        db(i).name = "Nephrite" : db(i).index = 1.6 : i += 1
        db(i).name = "Nickel" : db(i).index = 1.08 : i += 1
        db(i).name = "Nitrogen, gas" : db(i).index = 1.000297 : i += 1
        db(i).name = "Nitrogen, liq" : db(i).index = 1.2053 : i += 1
        db(i).name = "Nylon" : db(i).index = 1.53 : i += 1

        db(i).name = "Oil, clove" : db(i).index = 1.535 : i += 1
        db(i).name = "Oil, lemon" : db(i).index = 1.481 : i += 1
        db(i).name = "Oil, neroli" : db(i).index = 1.482 : i += 1
        db(i).name = "Oil, orange" : db(i).index = 1.473 : i += 1
        db(i).name = "Oil, safflower" : db(i).index = 1.466 : i += 1
        db(i).name = "Oil, vegetable (50° C)" : db(i).index = 1.47 : i += 1
        db(i).name = "Oil, wintergreen" : db(i).index = 1.536 : i += 1
        db(i).name = "Olivine" : db(i).index = 1.67 : i += 1
        db(i).name = "Onyx" : db(i).index = 1.486 : i += 1
        db(i).name = "Opal, black" : db(i).index = 1.45 : i += 1
        db(i).name = "Opal, fire" : db(i).index = 1.445 : i += 1
        db(i).name = "Opal, white" : db(i).index = 1.45 : i += 1
        db(i).name = "Oregon sunstone" : db(i).index = 1.566 : i += 1
        db(i).name = "Oxygen, gas" : db(i).index = 1.000276 : i += 1
        db(i).name = "Oxygen, liq" : db(i).index = 1.221 : i += 1

        db(i).name = "Padparadja" : db(i).index = 1.767 : i += 1
        db(i).name = "Painite" : db(i).index = 1.787 : i += 1
        db(i).name = "Pearl" : db(i).index = 1.53 : i += 1
        db(i).name = "Periclase" : db(i).index = 1.74 : i += 1
        db(i).name = "Peridot" : db(i).index = 1.654 : i += 1
        db(i).name = "Peristerite" : db(i).index = 1.525 : i += 1
        db(i).name = "Petalite" : db(i).index = 1.502 : i += 1
        db(i).name = "Phenakite" : db(i).index = 1.65 : i += 1
        db(i).name = "Phosgenite" : db(i).index = 2.117 : i += 1
        db(i).name = "Plastic" : db(i).index = 1.46 : i += 1
        db(i).name = "Platinum" : db(i).index = 2.33 : i += 1
        db(i).name = "Plexiglas" : db(i).index = 1.488 : i += 1
        db(i).name = "Polystyrene" : db(i).index = 1.55 : i += 1
        db(i).name = "Prase" : db(i).index = 1.54 : i += 1
        db(i).name = "Proustite" : db(i).index = 2.79 : i += 1
        db(i).name = "Propanol" : db(i).index = 1.359 : i += 1
        db(i).name = "Purpurite" : db(i).index = 1.84 : i += 1
        db(i).name = "Pyrite" : db(i).index = 1.81 : i += 1
        db(i).name = "Pyrope" : db(i).index = 1.74 : i += 1

        db(i).name = "Quartz" : db(i).index = 1.544 : i += 1
        db(i).name = "Quartz, fused" : db(i).index = 1.45843 : i += 1

        db(i).name = "Rhodizite" : db(i).index = 1.69 : i += 1
        db(i).name = "Rhodochrisite" : db(i).index = 1.6 : i += 1
        db(i).name = "Rhodonite" : db(i).index = 1.735 : i += 1
        db(i).name = "Rubber, natural" : db(i).index = 1.5191 : i += 1
        db(i).name = "Ruby" : db(i).index = 1.76 : i += 1
        db(i).name = "Rum, white" : db(i).index = 1.361 : i += 1
        db(i).name = "Rutile" : db(i).index = 2.62 : i += 1

        db(i).name = "Salt" : db(i).index = 1.516 : i += 1
        db(i).name = "Salt, rock" : db(i).index = 1.544 : i += 1
        db(i).name = "Sanidine" : db(i).index = 1.522 : i += 1
        db(i).name = "Sapphire" : db(i).index = 1.76 : i += 1
        db(i).name = "Scapolite" : db(i).index = 1.54 : i += 1
        db(i).name = "Scapolite, yellow" : db(i).index = 1.555 : i += 1
        db(i).name = "Scheelite" : db(i).index = 1.92 : i += 1
        db(i).name = "Selenium, amorphous" : db(i).index = 2.92 : i += 1
        db(i).name = "Serpentine" : db(i).index = 1.56 : i += 1
        db(i).name = "Shampoo" : db(i).index = 1.362 : i += 1
        db(i).name = "Shell" : db(i).index = 1.53 : i += 1
        db(i).name = "Silicon" : db(i).index = 4.24 : i += 1
        db(i).name = "Sillimanite" : db(i).index = 1.658 : i += 1
        db(i).name = "Silver" : db(i).index = 1.35 : i += 1
        db(i).name = "Sinhalite" : db(i).index = 1.699 : i += 1
        db(i).name = "Smaragdite" : db(i).index = 1.608 : i += 1
        db(i).name = "Smithsonite" : db(i).index = 1.621 : i += 1
        db(i).name = "Sodalite" : db(i).index = 1.483 : i += 1
        db(i).name = "Sodium chloride" : db(i).index = 1.5443 : i += 1
        db(i).name = "Sphalerite" : db(i).index = 2.368 : i += 1
        db(i).name = "Sphene" : db(i).index = 1.885 : i += 1
        db(i).name = "Spinel" : db(i).index = 1.712 : i += 1
        db(i).name = "Spodumene" : db(i).index = 1.65 : i += 1
        db(i).name = "Staurolite" : db(i).index = 1.739 : i += 1
        db(i).name = "Steatite" : db(i).index = 1.539 : i += 1
        db(i).name = "Steel" : db(i).index = 2.5 : i += 1
        db(i).name = "Stichtite" : db(i).index = 1.52 : i += 1
        db(i).name = "Strontium titanate" : db(i).index = 2.41 : i += 1
        db(i).name = "Styrofoam" : db(i).index = 1.595 : i += 1
        db(i).name = "Sugar, solution 30%" : db(i).index = 1.38 : i += 1
        db(i).name = "Sugar, solution 80%" : db(i).index = 1.49 : i += 1
        db(i).name = "Sulphur" : db(i).index = 1.96 : i += 1
        db(i).name = "Synthetic Spinel" : db(i).index = 1.73 : i += 1

        db(i).name = "Taaffeite" : db(i).index = 1.72 : i += 1
        db(i).name = "Tantalite" : db(i).index = 2.24 : i += 1
        db(i).name = "Tanzanite" : db(i).index = 1.691 : i += 1
        db(i).name = "Teflon" : db(i).index = 1.35 : i += 1
        db(i).name = "Thomsonite" : db(i).index = 1.53 : i += 1
        db(i).name = "Tiger eye" : db(i).index = 1.544 : i += 1
        db(i).name = "Titanium" : db(i).index = 2.16 : i += 1
        db(i).name = "Topaz, blue" : db(i).index = 1.61 : i += 1
        db(i).name = "Topaz, pink" : db(i).index = 1.62 : i += 1
        db(i).name = "Topaz, white" : db(i).index = 1.63 : i += 1
        db(i).name = "Topaz, yellow" : db(i).index = 1.62 : i += 1
        db(i).name = "Tourmaline" : db(i).index = 1.624 : i += 1
        db(i).name = "Tourmaline, blue" : db(i).index = 1.622 : i += 1
        db(i).name = "Tourmaline, catseye" : db(i).index = 1.622 : i += 1
        db(i).name = "Tourmaline, green" : db(i).index = 1.622 : i += 1
        db(i).name = "Tourmaline, paraiba" : db(i).index = 1.623 : i += 1
        db(i).name = "Tourmaline, red" : db(i).index = 1.622 : i += 1
        db(i).name = "Tremolite" : db(i).index = 1.6 : i += 1
        db(i).name = "Tugtupite" : db(i).index = 1.496 : i += 1
        db(i).name = "Turpentine" : db(i).index = 1.472 : i += 1
        db(i).name = "Turquoise" : db(i).index = 1.61 : i += 1

        db(i).name = "Ulexite" : db(i).index = 1.49 : i += 1
        db(i).name = "Uvarovite" : db(i).index = 1.87 : i += 1

        db(i).name = "Vacuum" : db(i).index = 1 : i += 1
        db(i).name = "Variscite" : db(i).index = 1.55 : i += 1
        db(i).name = "Vivianite" : db(i).index = 1.58 : i += 1
        db(i).name = "Vodka" : db(i).index = 1.363 : i += 1

        db(i).name = "Wardite" : db(i).index = 1.59 : i += 1
        db(i).name = "Water, gas" : db(i).index = 1.000261 : i += 1
        db(i).name = "Water 100'C" : db(i).index = 1.31819 : i += 1
        db(i).name = "Water 35'C" : db(i).index = 1.33157 : i += 1
        db(i).name = "Water 20'C" : db(i).index = 1.33335 : i += 1
        db(i).name = "Water 0'C" : db(i).index = 1.33346 : i += 1
        db(i).name = "Water, ice" : db(i).index = 1.309 : i += 1
        db(i).name = "Whisky" : db(i).index = 1.356 : i += 1
        db(i).name = "Willemite" : db(i).index = 1.69 : i += 1
        db(i).name = "Witherite" : db(i).index = 1.532 : i += 1
        db(i).name = "Wulfenite" : db(i).index = 2.3 : i += 1

        db(i).name = "Zincite" : db(i).index = 2.01 : i += 1
        db(i).name = "Zircon, high" : db(i).index = 1.96 : i += 1
        db(i).name = "Zircon, low" : db(i).index = 1.8 : i += 1
        db(i).name = "Zirconia, cubic" : db(i).index = 2.17 : i += 1

        dbLength = i

        RefreshList()
    End Sub

    Sub RefreshList()
        For i As Integer = 0 To dbLength - 1
            lstView.Items.Add(db(i).name)
        Next
    End Sub

    Private Function Find(ByVal db() As IORitem, ByVal Filter As String, ByVal First As Integer, ByVal Last As Integer) As Integer
        If Math.Abs(First - Last) <= 1 Then Return Last

        Dim mid As Integer = (First + Last) \ 2
        If Filter.ToLower < db(mid).name.ToLower Then
            Return Find(db, Filter, First, mid)

        ElseIf Filter.ToLower > db(mid).name.ToLower Then
            Return Find(db, Filter, mid, Last)

        Else
            Return mid
        End If

    End Function

    Private Sub lstView_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles lstView.DrawItem
        If e.Index = -1 Then Exit Sub

        If e.Index Mod 2 = 0 Then
            e.Graphics.FillRectangle(New SolidBrush(Color.FromArgb(140, 140, 140)), e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height)
        Else
            e.Graphics.FillRectangle(New SolidBrush(Color.Gray), e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height)
        End If

        If (e.State And DrawItemState.Selected) = DrawItemState.Selected Then
            e.Graphics.FillRectangle(New SolidBrush(Color.FromArgb(160, 160, 160)), e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height)
        End If

        e.Graphics.DrawString(e.Index.ToString + 1, Me.Font, Brushes.White, e.Bounds.X + 8, e.Bounds.Y + 1)
        e.Graphics.DrawString(db(e.Index).name, Me.Font, Brushes.White, e.Bounds.X + 48, e.Bounds.Y + 1)
        e.Graphics.DrawString(db(e.Index).index.ToString, Me.Font, Brushes.White, e.Bounds.X + 250, e.Bounds.Y + 1)
    End Sub

    Private Sub txtFilter_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFilter.TextChanged
        If txtFilter.Text = "" Then
            cmdClear.Enabled = False
            lstView.SelectedIndex = -1
        Else
            cmdClear.Enabled = True
            lstView.SelectedIndex = Find(db, txtFilter.Text.ToLower, 0, dbLength - 1)
        End If
    End Sub

    Private Sub cmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClear.Click
        txtFilter.Text = ""
    End Sub

    Private Sub lstView_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstView.DoubleClick
        If lstView.SelectedIndex = -1 Then Exit Sub
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub
End Class