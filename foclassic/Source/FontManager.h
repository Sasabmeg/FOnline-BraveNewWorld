#pragma once

#include <vector>

class FontManager
{
private:
	std::vector<int> DialogFonts;
public:
	FontManager() {};
	void clear();
	void add(int font);
	int getPrev(int currentFont);
	int getNext(int currentFont);
};

