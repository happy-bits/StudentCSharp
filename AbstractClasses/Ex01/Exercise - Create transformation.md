# Create transformation

Create a new class **ChangeSwedishLettersFileTransformer** that can be used like this

	var t3 = new ChangeSwedishLettersFileTransformer();
	t3.TransformFile(@"AbstractClasses\Ex01\sample3.txt");

This file:

	Dogecoin är en litecoinbaserad kryptovaluta. Dogecoin har sitt ursprung i internetmemen 'Doge', och dess logotyp är en hund av rasen Shiba. Dogecoin har till skillnad från bitcoin ingen maximal mängd monetära enheter, utan når sin maximala tillväxthastighet vid 100 miljarder enheter. Den 23 december 2013 hade 12,5 procent dogecoin av dessa 100 miljarder blivit utvunna. Dogecoin har uppmärksammats i flera olika tidningar för dess användares inblandning i olika välgörenhetskampanjer. åäöÅÄÖ.

...should create this transformed file:

	Dogecoin ar en litecoinbaserad kryptovaluta. Dogecoin har sitt ursprung i internetmemen 'Doge', och dess logotyp ar en hund av rasen Shiba. Dogecoin har till skillnad fran bitcoin ingen maximal mangd monetara enheter, utan nar sin maximala tillvaxthastighet vid 100 miljarder enheter. Den 23 december 2013 hade 12,5 procent dogecoin av dessa 100 miljarder blivit utvunna. Dogecoin har uppmarksammats i flera olika tidningar for dess anvandares inblandning i olika valgorenhetskampanjer. aaoAAO.