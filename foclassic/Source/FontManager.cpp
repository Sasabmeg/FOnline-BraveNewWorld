#include "FontManager.h"

void FontManager::clear() {
	DialogFonts.clear();
}

void FontManager::add(int font) {
	DialogFonts.push_back(font);
}

/**
 *	Gets the previous font loaded for Dialog purposes. If there is no font before, it returns the current.
 **/
int FontManager::getPrev(int currentFont) {
	for (int i = 0; i < DialogFonts.size(); i++) {
		if (DialogFonts[i] == currentFont) {
			if (i > 0) {
				return DialogFonts[i - 1];
			}
			else {
				return currentFont;
			}
		}
	}
	return currentFont;
}


// Gets the next font loaded for Dialog purposes. If there is no font after, it returns the current.
int FontManager::getNext(int currentFont) {
	for (int i = 0; i < DialogFonts.size(); i++) {
		if (DialogFonts[i] == currentFont) {
			if (i + 1 < DialogFonts.size()) {
				return DialogFonts[i + 1];
			}
			else {
				return currentFont;
			}
		}
	}
	return currentFont;
}
