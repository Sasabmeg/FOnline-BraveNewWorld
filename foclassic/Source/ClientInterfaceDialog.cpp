#include "Client.h"
#include "MsgStr.h"
#include "Text.h"
#include "Timer.h"
#include "GameOptions.h"
#include "Keyboard.h"
#include "Script.h"
#include <vector>

using namespace std;


void FOClient::RecalcDlgMainTextLinesReal() {
	if (IsScreenPresent(CLIENT_SCREEN_DIALOG))
	{
		DlgMainTextLinesReal = SprMngr.GetLinesCount(DlgWText.W(), 0, DlgMainText.c_str(), dialogFont);
	}
	else if (IsScreenPresent(CLIENT_SCREEN_BARTER))
	{
		DlgMainTextLinesReal = SprMngr.GetLinesCount(DlgWText.W(), 0, BarterText.c_str(), dialogFont);
	}
}

void FOClient::RecalcDlgMainTextLinesRect() {
	DlgMainTextLinesRect = SprMngr.GetLinesCount(0, DlgWText.H(), NULL, dialogFont);
}

void FOClient::RecalcDlgAnswerPositions() {

	DlgCurAnswPage = 0;
	DlgMaxAnswPage = 0;
	DlgAllAnswers.clear();
	DlgAnswers.clear();

	const char answ_beg[] = { ' ', ' ', (char)TEXT_SYMBOL_DOT, ' ', 0 };
	const char page_up[] = { (char)TEXT_SYMBOL_UP, (char)TEXT_SYMBOL_UP, (char)TEXT_SYMBOL_UP, 0 };
	const int  page_up_height = SprMngr.GetLinesHeight(DlgAnswText.W(), 0, page_up, dialogFont);
	const char page_down[] = { (char)TEXT_SYMBOL_DOWN, (char)TEXT_SYMBOL_DOWN, (char)TEXT_SYMBOL_DOWN, 0 };
	const int  page_down_height = SprMngr.GetLinesHeight(DlgAnswText.W(), 0, page_down, dialogFont);

	char str[MAX_FOTEXT];
	int        line = 0, height = 0, page = 0, answ = 0;
	while (true)
	{
		Rect pos(
			DlgAnswText.L + DlgNextAnswX * line,
			DlgAnswText.T + DlgNextAnswY * line + height,
			DlgAnswText.R + DlgNextAnswX * line,
			DlgAnswText.T + DlgNextAnswY * line + height);

		// Up arrow
		if (page && !line)
		{
			height += page_up_height;
			pos.B += page_up_height;
			line++;
			DlgAllAnswers.push_back(Answer(page, pos, page_up, -1));
			continue;
		}

		Str::Copy(str, MsgDlg->GetStr(answers_texts[answ]));
		FormatTags(str, MAX_FOTEXT, Chosen, npc, lexems);
		Str::Insert(str, answ_beg);      // TODO: GetStr

		height += SprMngr.GetLinesHeight(DlgAnswText.W(), 0, str, dialogFont);
		pos.B = DlgAnswText.T + DlgNextAnswY * line + height;

		if (pos.B >= DlgAnswText.B && line > 1)
		{
			// Down arrow
			Answer& answ_prev = DlgAllAnswers.back();
			if (line > 2 && DlgAnswText.B - answ_prev.Position.B < page_down_height)     // Check free space
			{
				// Not enough space
				// Migrate last answer to next page
				DlgAllAnswers.pop_back();
				pos = answ_prev.Position;
				pos.B = pos.T + page_down_height;
				DlgAllAnswers.push_back(Answer(page, pos, page_down, -2));
				answ--;
			}
			else
			{
				// Add down arrow
				pos.B = pos.T + page_down_height;
				DlgAllAnswers.push_back(Answer(page, pos, page_down, -2));
			}

			page++;
			height = 0;
			line = 0;
			DlgMaxAnswPage = page;
		}
		else
		{
			// Answer
			DlgAllAnswers.push_back(Answer(page, pos, str, answ));
			line++;
			answ++;
			if (answ >= count_answ)
				break;
		}
	}
	DlgCollectAnswers(false);
}

void FOClient::DlgDraw(bool is_dialog)
{
	SprMngr.DrawSprite(DlgPMain, DlgX, DlgY);
	if (!BarterIsPlayers && DlgAvatarPic)
		SprMngr.DrawSpriteSize(DlgAvatarPic, DlgWAvatar.L + DlgX, DlgWAvatar.T + DlgY, (float)DlgWAvatar.W(), (float)DlgWAvatar.H(), true, true);
	if (!Chosen)
		return;

	// Main pic
	if (is_dialog)
		SprMngr.DrawSprite(DlgPAnsw, DlgAnsw[0] + DlgX, DlgAnsw[1] + DlgY);
	else
		SprMngr.DrawSprite(BarterPMain, BarterWMain[0] + DlgX, BarterWMain[1] + DlgY);

	// Text scroll
	const char scr_up[] = { (char)TEXT_SYMBOL_UP, 0 };
	const char scr_down[] = { (char)TEXT_SYMBOL_DOWN, 0 };
	if (DlgMainTextCur)
		SprMngr.DrawStr(Rect(DlgBScrUp, DlgX, DlgY), scr_up, 0, IfaceHold == IFACE_DLG_SCR_UP ? COLOR_TEXT_DGREEN : COLOR_TEXT, dialogFont);
	if (DlgMainTextCur < DlgMainTextLinesReal - DlgMainTextLinesRect)
		SprMngr.DrawStr(Rect(DlgBScrDn, DlgX, DlgY), scr_down, 0, IfaceHold == IFACE_DLG_SCR_DN ? COLOR_TEXT_DGREEN : COLOR_TEXT, dialogFont);

	// Dialog
	if (is_dialog)
	{
		switch (IfaceHold)
		{
		case IFACE_DLG_BARTER:
			SprMngr.DrawSprite(DlgPBBarter, DlgBBarter[0] + DlgX, DlgBBarter[1] + DlgY);
			break;
		case IFACE_DLG_SAY:
			SprMngr.DrawSprite(DlgPBSay, DlgBSay[0] + DlgX, DlgBSay[1] + DlgY);
			break;
		default:
			break;
		}

		// Texts
		SprMngr.DrawStr(Rect(DlgBBarterText, DlgX, DlgY), MsgGame->GetStr(STR_DIALOG_BARTER), FONT_FLAG_CENTERX | FONT_FLAG_CENTERY, COLOR_TEXT_SAND, FONT_TYPE_FAT);
		SprMngr.DrawStr(Rect(DlgBSayText, DlgX, DlgY), MsgGame->GetStr(STR_DIALOG_SAY), FONT_FLAG_CENTERX | FONT_FLAG_CENTERY, COLOR_TEXT_SAND, FONT_TYPE_FAT);

		// Npc text
		SprMngr.DrawStr(Rect(DlgWText, DlgX, DlgY), DlgMainText.c_str(), FONT_FLAG_SKIPLINES(DlgMainTextCur), COLOR_TEXT, dialogFont);

		// Answers
		for (uint i = 0; i < DlgAnswers.size(); i++)
		{
			Answer& a = DlgAnswers[i];
			if (i == (uint)DlgCurAnsw) {
				uint color = (IfaceHold == IFACE_DLG_ANSWER && DlgCurAnsw == DlgHoldAnsw) ? COLOR_TEXT_DDGREEN : (IfaceHold != IFACE_DLG_ANSWER ? COLOR_TEXT_DGREEN : COLOR_TEXT);
				if (IsCurInRect(DlgAnswText, DlgX, DlgY) && IfaceHold != IFACE_DLG_ANSWER)
					color = COLOR_TEXT_WHITE;
				SprMngr.DrawStr(Rect(a.Position, DlgX, DlgY), (" " + to_string((unsigned long long)i + 1) + "." + DlgAnswers[i].Text).c_str(), a.AnswerNum < 0 ? FONT_FLAG_CENTERX : 0, color, dialogFont);
			}
			else
				SprMngr.DrawStr(Rect(a.Position, DlgX, DlgY), (" " + to_string((unsigned long long)i + 1) + "." + DlgAnswers[i].Text).c_str(), a.AnswerNum < 0 ? FONT_FLAG_CENTERX : 0, COLOR_TEXT, dialogFont);
		}

		// Chosen money
		if (Chosen)
			SprMngr.DrawStr(Rect(DlgWMoney, DlgX, DlgY), Chosen->GetMoneyStr(), FONT_FLAG_CENTERX | FONT_FLAG_CENTERY, COLOR_TEXT_WHITE, dialogFont);
	}
	// Barter
	else
	{
		if (BarterIsPlayers && BarterOffer)
			SprMngr.DrawSprite(BarterPBOfferDn, BarterBOffer[0] + DlgX, BarterBOffer[1] + DlgY);

		switch (IfaceHold)
		{
		case IFACE_BARTER_OFFER:
			SprMngr.DrawSprite(BarterPBOfferDn, BarterBOffer[0] + DlgX, BarterBOffer[1] + DlgY);
			break;
		case IFACE_BARTER_TALK:
			SprMngr.DrawSprite(BarterPBTalkDn, BarterBTalk[0] + DlgX, BarterBTalk[1] + DlgY);
			break;
		case IFACE_BARTER_CONT1SU:
			SprMngr.DrawSprite(BarterPBC1ScrUpDn, BarterBCont1ScrUp[0] + DlgX, BarterBCont1ScrUp[1] + DlgY);
			break;
		case IFACE_BARTER_CONT1SD:
			SprMngr.DrawSprite(BarterPBC1ScrDnDn, BarterBCont1ScrDn[0] + DlgX, BarterBCont1ScrDn[1] + DlgY);
			break;
		case IFACE_BARTER_CONT2SU:
			SprMngr.DrawSprite(BarterPBC2ScrUpDn, BarterBCont2ScrUp[0] + DlgX, BarterBCont2ScrUp[1] + DlgY);
			break;
		case IFACE_BARTER_CONT2SD:
			SprMngr.DrawSprite(BarterPBC2ScrDnDn, BarterBCont2ScrDn[0] + DlgX, BarterBCont2ScrDn[1] + DlgY);
			break;
		case IFACE_BARTER_CONT1OSU:
			SprMngr.DrawSprite(BarterPBC1oScrUpDn, BarterBCont1oScrUp[0] + DlgX, BarterBCont1oScrUp[1] + DlgY);
			break;
		case IFACE_BARTER_CONT1OSD:
			SprMngr.DrawSprite(BarterPBC1oScrDnDn, BarterBCont1oScrDn[0] + DlgX, BarterBCont1oScrDn[1] + DlgY);
			break;
		case IFACE_BARTER_CONT2OSU:
			SprMngr.DrawSprite(BarterPBC2oScrUpDn, BarterBCont2oScrUp[0] + DlgX, BarterBCont2oScrUp[1] + DlgY);
			break;
		case IFACE_BARTER_CONT2OSD:
			SprMngr.DrawSprite(BarterPBC2oScrDnDn, BarterBCont2oScrDn[0] + DlgX, BarterBCont2oScrDn[1] + DlgY);
			break;
		default:
			break;
		}

		Chosen->DrawStay(Rect(BarterWChosen, DlgX, DlgY));
		CritterCl* cr = GetCritter(BarterIsPlayers ? BarterOpponentId : DlgNpcId);
		if (cr)
			cr->DrawStay(Rect(BarterWCritter, DlgX, DlgY));

		SprMngr.Flush();

		// Items
		ContainerDraw(Rect(BarterWCont1, DlgX, DlgY), BarterCont1HeightItem, BarterScroll1, BarterCont1, IfaceHold == IFACE_BARTER_CONT1 ? BarterHoldId : 0);
		ContainerDraw(Rect(BarterWCont2, DlgX, DlgY), BarterCont2HeightItem, BarterScroll2, BarterCont2, IfaceHold == IFACE_BARTER_CONT2 ? BarterHoldId : 0);
		ContainerDraw(Rect(BarterWCont1o, DlgX, DlgY), BarterCont1oHeightItem, BarterScroll1o, BarterCont1o, IfaceHold == IFACE_BARTER_CONT1O ? BarterHoldId : 0);
		ContainerDraw(Rect(BarterWCont2o, DlgX, DlgY), BarterCont2oHeightItem, BarterScroll2o, BarterCont2o, IfaceHold == IFACE_BARTER_CONT2O ? BarterHoldId : 0);

		// Info
		SprMngr.DrawStr(Rect(BarterBOfferText, DlgX, DlgY), MsgGame->GetStr(STR_BARTER_OFFER), FONT_FLAG_NOBREAK | FONT_FLAG_CENTERX | FONT_FLAG_CENTERY, COLOR_TEXT_SAND, FONT_TYPE_FAT);
		if (BarterIsPlayers)
		{
			SprMngr.DrawStr(Rect(BarterBTalkText, DlgX, DlgY), MsgGame->GetStr(STR_BARTER_END), FONT_FLAG_NOBREAK | FONT_FLAG_CENTERX | FONT_FLAG_CENTERY, COLOR_TEXT_SAND, FONT_TYPE_FAT);
			SprMngr.DrawStr(Rect(DlgWText, DlgX, DlgY), BarterText.c_str(), FONT_FLAG_UPPER, 0, dialogFont);
		}
		else
		{
			SprMngr.DrawStr(Rect(BarterBTalkText, DlgX, DlgY), MsgGame->GetStr(STR_BARTER_TALK), FONT_FLAG_NOBREAK | FONT_FLAG_CENTERX | FONT_FLAG_CENTERY, COLOR_TEXT_SAND, FONT_TYPE_FAT);
			SprMngr.DrawStr(Rect(DlgWText, DlgX, DlgY), BarterText.c_str(), 0, 0, dialogFont);
		}

		// Cost
		uint c1, w1, v1, c2, w2, v2;
		ContainerCalcInfo(BarterCont1o, c1, w1, v1, -BarterK, true);
		ContainerCalcInfo(BarterCont2o, c2, w2, v2, Chosen->IsRawParam(PE_MASTER_TRADER) ? 0 : BarterK, false);
		if (!BarterIsPlayers && BarterK)
		{
			SprMngr.DrawStr(Rect(BarterWCost1, DlgX, DlgY), Str::FormatBuf("$%u", c1), FONT_FLAG_NOBREAK | FONT_FLAG_CENTERX, COLOR_TEXT_WHITE, dialogFont); // BarterCost1<BarterCost2?COLOR_TEXT_RED:COLOR_TEXT_WHITE);
			SprMngr.DrawStr(Rect(BarterWCost2, DlgX, DlgY), Str::FormatBuf("$%u", c2), FONT_FLAG_NOBREAK | FONT_FLAG_CENTERX, COLOR_TEXT_WHITE, dialogFont); // BarterCost1<BarterCost2?COLOR_TEXT_RED:COLOR_TEXT_WHITE);
		}
		else
		{
			SprMngr.DrawStr(Rect(BarterWCost1, DlgX, DlgY), Str::FormatBuf("%u", w1 / 1000), FONT_FLAG_NOBREAK | FONT_FLAG_CENTERX, COLOR_TEXT_WHITE, dialogFont); // BarterCost1<BarterCost2?COLOR_TEXT_RED:COLOR_TEXT_WHITE);
			SprMngr.DrawStr(Rect(BarterWCost2, DlgX, DlgY), Str::FormatBuf("%u", w2 / 1000), FONT_FLAG_NOBREAK | FONT_FLAG_CENTERX, COLOR_TEXT_WHITE, dialogFont); // BarterCost1<BarterCost2?COLOR_TEXT_RED:COLOR_TEXT_WHITE);
		}
		// Overweight, oversize indicate
		if (Chosen->GetFreeWeight() + (int)w1 < (int)w2)
			SprMngr.DrawStr(Rect(DlgWText.L, DlgWText.B - 5, DlgWText.R, DlgWText.B + 10, DlgX, DlgY), MsgGame->GetStr(STR_OVERWEIGHT_TITLE), FONT_FLAG_NOBREAK | FONT_FLAG_CENTERX, COLOR_TEXT_DDGREEN, dialogFont);
		else if (Chosen->GetFreeVolume() + (int)v1 < (int)v2)
			SprMngr.DrawStr(Rect(DlgWText.L, DlgWText.B - 5, DlgWText.R, DlgWText.B + 10, DlgX, DlgY), MsgGame->GetStr(STR_OVERVOLUME_TITLE), FONT_FLAG_NOBREAK | FONT_FLAG_CENTERX, COLOR_TEXT_DDGREEN, dialogFont);
	}

	// Timer
	if (!BarterIsPlayers && DlgEndTick && DlgEndTick > Timer::GameTick())
		SprMngr.DrawStr(Rect(DlgWTimer, DlgX, DlgY), Str::FormatBuf("%u", (DlgEndTick - Timer::GameTick()) / 1000), FONT_FLAG_NOBREAK | FONT_FLAG_CENTERX | FONT_FLAG_CENTERY, COLOR_TEXT_DGREEN, dialogFont);
}

void FOClient::DlgLMouseDown(bool is_dialog)
{
	IfaceHold = IFACE_NONE;
	BarterHoldId = 0;

	if (!IsCurInRect(DlgWMain, DlgX, DlgY))
		return;

	if (IsCurInRect(DlgBScrUp, DlgX, DlgY))
	{
		if (DlgMainTextCur > 0)
		{
			IfaceHold = IFACE_DLG_SCR_UP;
			Timer::StartAccelerator(ACCELERATE_DLG_TEXT_UP);
		}
	}
	else if (IsCurInRect(DlgBScrDn, DlgX, DlgY))
	{
		if (DlgMainTextCur < DlgMainTextLinesReal - DlgMainTextLinesRect)
		{
			IfaceHold = IFACE_DLG_SCR_DN;
			Timer::StartAccelerator(ACCELERATE_DLG_TEXT_DOWN);
		}
	}

	// Dialog
	if (is_dialog && IsCurInRect(DlgWMain, DlgX, DlgY))
	{
		if (IsCurInRect(DlgAnswText, DlgX, DlgY))
		{
			IfaceHold = IFACE_DLG_ANSWER;
			DlgHoldAnsw = DlgCurAnsw;
		}
		else if (IsCurInRect(DlgBBarter, DlgX, DlgY))
			IfaceHold = IFACE_DLG_BARTER;
		else if (IsCurInRect(DlgBSay, DlgX, DlgY))
			IfaceHold = IFACE_DLG_SAY;
	}
	// Barter
	else if (!is_dialog && IsCurInRect(BarterWMain, DlgX, DlgY))
	{
		if (IsCurInRect(BarterWCont1, DlgX, DlgY))
		{
			BarterHoldId = GetCurContainerItemId(Rect(BarterWCont1, DlgX, DlgY), BarterCont1HeightItem, BarterScroll1, BarterCont1);
			if (!BarterHoldId)
				return;
			IfaceHold = IFACE_BARTER_CONT1;
		}
		else if (IsCurInRect(BarterWCont2, DlgX, DlgY))
		{
			if (!(BarterIsPlayers && BarterOpponentHide))
			{
				BarterHoldId = GetCurContainerItemId(Rect(BarterWCont2, DlgX, DlgY), BarterCont2HeightItem, BarterScroll2, BarterCont2);
				if (!BarterHoldId)
					return;
				IfaceHold = IFACE_BARTER_CONT2;
			}
		}
		else if (IsCurInRect(BarterWCont1o, DlgX, DlgY))
		{
			BarterHoldId = GetCurContainerItemId(Rect(BarterWCont1o, DlgX, DlgY), BarterCont1oHeightItem, BarterScroll1o, BarterCont1o);
			if (!BarterHoldId)
				return;
			IfaceHold = IFACE_BARTER_CONT1O;
		}
		else if (IsCurInRect(BarterWCont2o, DlgX, DlgY))
		{
			if (!(BarterIsPlayers && BarterOpponentHide))
			{
				BarterHoldId = GetCurContainerItemId(Rect(BarterWCont2o, DlgX, DlgY), BarterCont2oHeightItem, BarterScroll2o, BarterCont2o);
				if (!BarterHoldId)
					return;
				IfaceHold = IFACE_BARTER_CONT2O;
			}
		}
		else if (IsCurInRect(BarterBOffer, DlgX, DlgY))
			IfaceHold = IFACE_BARTER_OFFER;
		else if (IsCurInRect(BarterBTalk, DlgX, DlgY))
			IfaceHold = IFACE_BARTER_TALK;
		else if (IsCurInRect(BarterBCont1ScrUp, DlgX, DlgY))
		{
			Timer::StartAccelerator(ACCELERATE_BARTER_CONT1SU);
			IfaceHold = IFACE_BARTER_CONT1SU;
		}
		else if (IsCurInRect(BarterBCont1ScrDn, DlgX, DlgY))
		{
			Timer::StartAccelerator(ACCELERATE_BARTER_CONT1SD);
			IfaceHold = IFACE_BARTER_CONT1SD;
		}
		else if (IsCurInRect(BarterBCont2ScrUp, DlgX, DlgY))
		{
			Timer::StartAccelerator(ACCELERATE_BARTER_CONT2SU);
			IfaceHold = IFACE_BARTER_CONT2SU;
		}
		else if (IsCurInRect(BarterBCont2ScrDn, DlgX, DlgY))
		{
			Timer::StartAccelerator(ACCELERATE_BARTER_CONT2SD);
			IfaceHold = IFACE_BARTER_CONT2SD;
		}
		else if (IsCurInRect(BarterBCont1oScrUp, DlgX, DlgY))
		{
			Timer::StartAccelerator(ACCELERATE_BARTER_CONT1OSU);
			IfaceHold = IFACE_BARTER_CONT1OSU;
		}
		else if (IsCurInRect(BarterBCont1oScrDn, DlgX, DlgY))
		{
			Timer::StartAccelerator(ACCELERATE_BARTER_CONT1OSD);
			IfaceHold = IFACE_BARTER_CONT1OSD;
		}
		else if (IsCurInRect(BarterBCont2oScrUp, DlgX, DlgY))
		{
			Timer::StartAccelerator(ACCELERATE_BARTER_CONT2OSU);
			IfaceHold = IFACE_BARTER_CONT2OSU;
		}
		else if (IsCurInRect(BarterBCont2oScrDn, DlgX, DlgY))
		{
			Timer::StartAccelerator(ACCELERATE_BARTER_CONT2OSD);
			IfaceHold = IFACE_BARTER_CONT2OSD;
		}
		else if (IsCurInRect(DlgBScrUp, DlgX, DlgY) && BarterIsPlayers)
			IfaceHold = IFACE_DLG_SCR_UP;
		else if (IsCurInRect(DlgBScrDn, DlgX, DlgY) && BarterIsPlayers)
			IfaceHold = IFACE_DLG_SCR_DN;

		if (IsCurMode(CURSOR_DEFAULT) && (IfaceHold == IFACE_BARTER_CONT1 || IfaceHold == IFACE_BARTER_CONT2 || IfaceHold == IFACE_BARTER_CONT1O || IfaceHold == IFACE_BARTER_CONT2O))
		{
			IfaceHold = IFACE_NONE;
			LMenuTryActivate();
			return;
		}
	}

	if (IfaceHold == IFACE_NONE)
	{
		DlgVectX = GameOpt.MouseX - DlgX;
		DlgVectY = GameOpt.MouseY - DlgY;
		IfaceHold = IFACE_DLG_MAIN;
	}
}

void FOClient::DlgLMouseUp(bool is_dialog)
{
	if (!Chosen)
		return;

	if (IfaceHold == IFACE_DLG_SCR_UP && IsCurInRect(DlgBScrUp, DlgX, DlgY))
	{
		if (DlgMainTextCur > 0)
			DlgMainTextCur--;
	}
	else if (IfaceHold == IFACE_DLG_SCR_DN && IsCurInRect(DlgBScrDn, DlgX, DlgY))
	{
		if (DlgMainTextCur < DlgMainTextLinesReal - DlgMainTextLinesRect)
			DlgMainTextCur++;
	}

	if (is_dialog)
	{
		if (IfaceHold == IFACE_DLG_ANSWER && IsCurInRect(DlgAnswText, DlgX, DlgY))
		{
			if (DlgCurAnsw == DlgHoldAnsw && DlgCurAnsw >= 0 && DlgCurAnsw < (int)DlgAnswers.size() && IsCurInRect(DlgAnswers[DlgCurAnsw].Position, DlgX, DlgY))
			{
				if (DlgAnswers[DlgCurAnsw].AnswerNum < 0)
				{
					DlgCollectAnswers(DlgAnswers[DlgCurAnsw].AnswerNum == -2);
				}
				else
				{
					Net_SendTalk(DlgIsNpc, DlgNpcId, DlgAnswers[DlgCurAnsw].AnswerNum);
					WaitPing();
				}
			}
		}
		else if (IfaceHold == IFACE_DLG_BARTER && IsCurInRect(DlgBBarter, DlgX, DlgY))
		{
			CritterCl* cr = GetCritter(DlgNpcId);
			if (!cr || cr->IsRawParam(MODE_NO_BARTER))
			{
				DlgMainText = MsgGame->GetStr(STR_BARTER_NO_BARTER_MODE);
				DlgMainTextCur = 0;
				DlgMainTextLinesReal = SprMngr.GetLinesCount(DlgWText.W(), 0, DlgMainText.c_str(), dialogFont);
			}
			else
			{
				Net_SendTalk(DlgIsNpc, DlgNpcId, ANSWER_BARTER);
				WaitPing();
				HideScreen(CLIENT_SCREEN_DIALOG);
				ShowScreen(CLIENT_SCREEN_BARTER);
				CollectContItems();
				BarterCont1o.clear();
				BarterCont2.clear();
				BarterCont2o.clear();
				BarterText = "";
				DlgMainTextCur = 0;
				DlgMainTextLinesReal = SprMngr.GetLinesCount(DlgWText.W(), 0, BarterText.c_str(), dialogFont);
			}
		}
		else if (IfaceHold == IFACE_DLG_SAY && IsCurInRect(DlgBSay, DlgX, DlgY))
		{
			ShowScreen(CLIENT_SCREEN_SAY);
			SayType = DIALOGSAY_TEXT;
			SayText = "";
		}
	}
	else
	{
		if (IfaceHold == IFACE_BARTER_CONT1)
		{
			if (IsCurInRect(BarterWCont1o, DlgX, DlgY))
			{
				auto it = std::find(BarterCont1.begin(), BarterCont1.end(), BarterHoldId);
				if (it != BarterCont1.end())
				{
					Item& item = *it;
					if (item.GetCount() > 1)
						SplitStart(&item, IFACE_BARTER_CONT1);
					else
						BarterTransfer(BarterHoldId, IFACE_BARTER_CONT1, item.GetCount());
				}
			}
		}
		else if (IfaceHold == IFACE_BARTER_CONT2)
		{
			if (IsCurInRect(BarterWCont2o, DlgX, DlgY) && !(BarterIsPlayers && BarterOpponentHide))
			{
				auto it = std::find(BarterCont2.begin(), BarterCont2.end(), BarterHoldId);
				if (it != BarterCont2.end())
				{
					Item& item = *it;
					if (item.GetCount() > 1)
						SplitStart(&item, IFACE_BARTER_CONT2);
					else
						BarterTransfer(BarterHoldId, IFACE_BARTER_CONT2, item.GetCount());
				}
			}
		}
		else if (IfaceHold == IFACE_BARTER_CONT1O)
		{
			if (IsCurInRect(BarterWCont1, DlgX, DlgY))
			{
				auto it = std::find(BarterCont1o.begin(), BarterCont1o.end(), BarterHoldId);
				if (it != BarterCont1o.end())
				{
					Item& item = *it;
					if (item.GetCount() > 1)
						SplitStart(&item, IFACE_BARTER_CONT1O);
					else
						BarterTransfer(BarterHoldId, IFACE_BARTER_CONT1O, item.GetCount());
				}
			}
		}
		else if (IfaceHold == IFACE_BARTER_CONT2O)
		{
			if (IsCurInRect(BarterWCont2, DlgX, DlgY) && !(BarterIsPlayers && BarterOpponentHide))
			{
				auto it = std::find(BarterCont2o.begin(), BarterCont2o.end(), BarterHoldId);
				if (it != BarterCont2o.end())
				{
					Item& item = *it;
					if (item.GetCount() > 1)
						SplitStart(&item, IFACE_BARTER_CONT2O);
					else
						BarterTransfer(BarterHoldId, IFACE_BARTER_CONT2O, item.GetCount());
				}
			}
		}
		else if (IfaceHold == IFACE_BARTER_OFFER && IsCurInRect(BarterBOffer, DlgX, DlgY))
		{
			BarterTryOffer();
		}
		else if (IfaceHold == IFACE_BARTER_TALK && IsCurInRect(BarterBTalk, DlgX, DlgY))
		{
			if (BarterIsPlayers)
			{
				Net_SendPlayersBarter(BARTER_END, 0, 0);
				ShowScreen(CLIENT_SCREEN_NONE);
			}
			else
			{
				Net_SendTalk(DlgIsNpc, DlgNpcId, ANSWER_BEGIN);
				WaitPing();
			}
			CollectContItems();
		}
		else if (IfaceHold == IFACE_BARTER_CONT1SU && IsCurInRect(BarterBCont1ScrUp, DlgX, DlgY))
		{
			if (BarterScroll1 > 0)
				BarterScroll1--;
		}
		else if (IfaceHold == IFACE_BARTER_CONT1SD && IsCurInRect(BarterBCont1ScrDn, DlgX, DlgY))
		{
			if (BarterScroll1 < (int)Chosen->GetItemsCountInv() - (BarterWCont1[3] - BarterWCont1[1]) / BarterCont1HeightItem - (int)BarterCont1o.size())
				BarterScroll1++;
		}
		else if (IfaceHold == IFACE_BARTER_CONT2SU && IsCurInRect(BarterBCont2ScrUp, DlgX, DlgY))
		{
			if (BarterScroll2 > 0)
				BarterScroll2--;
		}
		else if (IfaceHold == IFACE_BARTER_CONT2SD && IsCurInRect(BarterBCont2ScrDn, DlgX, DlgY))
		{
			if (BarterScroll2 < (int)BarterCont2.size() - (BarterWCont2[3] - BarterWCont2[1]) / BarterCont2HeightItem)
				BarterScroll2++;
		}
		else if (IfaceHold == IFACE_BARTER_CONT1OSU && IsCurInRect(BarterBCont1oScrUp, DlgX, DlgY))
		{
			if (BarterScroll1o > 0)
				BarterScroll1o--;
		}
		else if (IfaceHold == IFACE_BARTER_CONT1OSD && IsCurInRect(BarterBCont1oScrDn, DlgX, DlgY))
		{
			if (BarterScroll1o < (int)BarterCont1o.size() - (BarterWCont1o[3] - BarterWCont1o[1]) / BarterCont1oHeightItem)
				BarterScroll1o++;
		}
		else if (IfaceHold == IFACE_BARTER_CONT2OSU && IsCurInRect(BarterBCont2oScrUp, DlgX, DlgY))
		{
			if (BarterScroll2o > 0)
				BarterScroll2o--;
		}
		else if (IfaceHold == IFACE_BARTER_CONT2OSD && IsCurInRect(BarterBCont2oScrDn, DlgX, DlgY))
		{
			if (BarterScroll2o < (int)BarterCont2o.size() - (BarterWCont2o[3] - BarterWCont2o[1]) / BarterCont2oHeightItem)
				BarterScroll2o++;
		}
		else if (IfaceHold == IFACE_DLG_SCR_UP && IsCurInRect(DlgBScrUp, DlgX, DlgY) && BarterIsPlayers)
		{
		}
		else if (IfaceHold == IFACE_DLG_SCR_DN && IsCurInRect(DlgBScrDn, DlgX, DlgY) && BarterIsPlayers)
		{
		}
	}

	IfaceHold = IFACE_NONE;
	BarterHoldId = 0;
}

void FOClient::DlgMouseMove(bool is_dialog)
{
	if (is_dialog)
	{
		DlgCurAnsw = -1;
		for (uint i = 0; i < DlgAnswers.size(); i++)
		{
			if (IsCurInRect(DlgAnswers[i].Position, DlgX, DlgY))
			{
				DlgCurAnsw = i;
				break;
			}
		}
	}

	if (IfaceHold == IFACE_DLG_MAIN)
	{
		DlgX = GameOpt.MouseX - DlgVectX;
		DlgY = GameOpt.MouseY - DlgVectY;

		if (DlgX < 0)
			DlgX = 0;
		if (DlgX + DlgWMain[2] > MODE_WIDTH)
			DlgX = MODE_WIDTH - DlgWMain[2];
		if (DlgY < 0)
			DlgY = 0;
		// if(DlgY+DlgMain[3]>IntY) DlgY=IntY-DlgMain[3];
		if (DlgY + DlgWMain[3] > MODE_HEIGHT)
			DlgY = MODE_HEIGHT - DlgWMain[3];
	}
}

void FOClient::DlgRMouseDown(bool is_dialog)
{
	if (!is_dialog)
		SetCurCastling(CURSOR_DEFAULT, CURSOR_HAND);
}

void FOClient::DlgKeyDown(bool is_dialog, uint8 dik, const char* dik_text)
{
	int num = -1;
	switch (dik)
	{
	case DIK_ESCAPE:
	case DIK_0:
	case DIK_NUMPAD0:
		if (BarterIsPlayers)
		{
			Net_SendPlayersBarter(BARTER_END, 0, 0);
			ShowScreen(CLIENT_SCREEN_NONE);
		}
		else
		{
			Net_SendTalk(DlgIsNpc, DlgNpcId, ANSWER_END);
			WaitPing();
		}
		CollectContItems();
		return;
	case DIK_INSERT:
		BarterTryOffer();
		return;
	case DIK_1:
	case DIK_NUMPAD1:
		num = 0;
		break;
	case DIK_2:
	case DIK_NUMPAD2:
		num = 1;
		break;
	case DIK_3:
	case DIK_NUMPAD3:
		num = 2;
		break;
	case DIK_4:
	case DIK_NUMPAD4:
		num = 3;
		break;
	case DIK_5:
	case DIK_NUMPAD5:
		num = 4;
		break;
	case DIK_6:
	case DIK_NUMPAD6:
		num = 5;
		break;
	case DIK_7:
	case DIK_NUMPAD7:
		num = 6;
		break;
	case DIK_8:
	case DIK_NUMPAD8:
		num = 7;
		break;
	case DIK_9:
	case DIK_NUMPAD9:
		num = 8;
		break;
	case DIK_UP:
		DlgCollectAnswers(false);
		return;
	case DIK_DOWN:
		DlgCollectAnswers(true);
		return;
	default:
		return;
	}

	if (is_dialog && num < (int)DlgAnswers.size())
	{
		if (DlgAnswers[num].AnswerNum < 0)
		{
			DlgCollectAnswers(DlgAnswers[num].AnswerNum == -2);
		}
		else
		{
			Net_SendTalk(DlgIsNpc, DlgNpcId, DlgAnswers[num].AnswerNum);
			WaitPing();
		}
	}
}

void FOClient::DlgCollectAnswers(bool next)
{
	if (next && DlgCurAnswPage < DlgMaxAnswPage)
		DlgCurAnswPage++;
	if (!next && DlgCurAnswPage > 0)
		DlgCurAnswPage--;

	DlgAnswers.clear();
	for (uint i = 0, j = (uint)DlgAllAnswers.size(); i < j; i++)
	{
		Answer& a = DlgAllAnswers[i];
		if (a.Page == DlgCurAnswPage)
			DlgAnswers.push_back(a);
	}
	DlgMouseMove(true);
}

bool FOClient::IsScreenPlayersBarter()
{
	return IsScreenPresent(CLIENT_SCREEN_BARTER) && BarterIsPlayers;
}

void FOClient::BarterTryOffer()
{
	if (!Chosen)
		return;

	if (BarterIsPlayers)
	{
		BarterOffer = !BarterOffer;
		Net_SendPlayersBarter(BARTER_OFFER, BarterOffer, 0);
	}
	else
	{
		uint c1, w1, v1, c2, w2, v2;
		ContainerCalcInfo(BarterCont1oInit, c1, w1, v1, -BarterK, true);
		ContainerCalcInfo(BarterCont2oInit, c2, w2, v2, Chosen->IsRawParam(PE_MASTER_TRADER) ? 0 : BarterK, false);
		if (!c1 && !c2 && BarterK)
			return;
		if (c1 < c2 && BarterK)
			BarterText = MsgGame->GetStr(STR_BARTER_BAD_OFFER);
		else if (Chosen->GetFreeWeightDoubled() + w1 < w2)
			BarterText = MsgGame->GetStr(STR_BARTER_OVERWEIGHT);
		else if (Chosen->GetFreeVolume() + v1 < v2)
			BarterText = MsgGame->GetStr(STR_BARTER_OVERSIZE);
		else
		{
			Net_SendBarter(DlgNpcId, BarterCont1oInit, BarterCont2oInit);
			WaitPing();
			return;
		}
		DlgMainTextCur = 0;
		DlgMainTextLinesReal = SprMngr.GetLinesCount(DlgWText.W(), 0, BarterText.c_str(), dialogFont);
	}
}

void FOClient::BarterTransfer(uint item_id, int item_cont, uint item_count)
{
	if (!item_count || !Chosen)
		return;

	ItemVec* from_cont;
	ItemVec* to_cont;

	switch (item_cont)
	{
	case IFACE_BARTER_CONT1:
		from_cont = &InvContInit;
		to_cont = &BarterCont1oInit;
		break;
	case IFACE_BARTER_CONT2:
		from_cont = &BarterCont2Init;
		to_cont = &BarterCont2oInit;
		break;
	case IFACE_BARTER_CONT1O:
		from_cont = &BarterCont1oInit;
		to_cont = &InvContInit;
		break;
	case IFACE_BARTER_CONT2O:
		from_cont = &BarterCont2oInit;
		to_cont = &BarterCont2Init;
		break;
	default:
		return;
	}

	auto it = std::find(from_cont->begin(), from_cont->end(), item_id);
	if (it == from_cont->end())
		return;

	Item* item = &(*it);
	Item* to_item = NULL;

	if (item->GetCount() < item_count)
		return;

	if (item->IsStackable())
	{
		auto it_to = std::find(to_cont->begin(), to_cont->end(), item->GetId());
		if (it_to != to_cont->end())
			to_item = &(*it_to);
	}

	if (to_item)
	{
		to_item->Count_Add(item_count);
	}
	else
	{
		to_cont->push_back(*item);
		Item& last = (*to_cont)[to_cont->size() - 1];
		last.Count_Set(item_count);
	}

	item->Count_Sub(item_count);
	if (!item->GetCount() || !item->IsStackable())
		from_cont->erase(it);
	CollectContItems();

	switch (item_cont)
	{
	case IFACE_BARTER_CONT1:
		if (BarterIsPlayers)
			Net_SendPlayersBarter(BARTER_SET_SELF, item_id, item_count);
		break;
	case IFACE_BARTER_CONT2:
		if (BarterIsPlayers)
			Net_SendPlayersBarter(BARTER_SET_OPPONENT, item_id, item_count);
		break;
	case IFACE_BARTER_CONT1O:
		if (BarterIsPlayers)
			Net_SendPlayersBarter(BARTER_UNSET_SELF, item_id, item_count);
		break;
	case IFACE_BARTER_CONT2O:
		if (BarterIsPlayers)
			Net_SendPlayersBarter(BARTER_UNSET_OPPONENT, item_id, item_count);
		break;
	default:
		break;
	}
}

void FOClient::ContainerCalcInfo(ItemVec& cont, uint& cost, uint& weigth, uint& volume, int barter_k, bool sell)
{
	cost = 0;
	weigth = 0;
	volume = 0;
	for (auto it = cont.begin(); it != cont.end(); it++)
	{
		Item& item = *it;
		if (barter_k != MAX_INT)
		{
			uint cost_ = item.GetCost1st();
			if (GameOpt.CustomItemCost)
			{
				CritterCl* npc = GetCritter(PupContId);
				if (Chosen && npc && Script::PrepareContext(ClientFunctions.ItemCost, _FUNC_, Chosen->GetInfo()))
				{
					Script::SetArgObject(&item);
					Script::SetArgObject(Chosen);
					Script::SetArgObject(npc);
					Script::SetArgBool(sell);
					if (Script::RunPrepared())
						cost_ = Script::GetReturnedUInt();
				}
			}
			else
			{
				cost_ = cost_ * (100 + barter_k) / 100;
				if (!cost_)
					cost_++;
			}
			cost += cost_ * item.GetCount();
		}
		weigth += item.GetWeight();
		volume += item.GetVolume();
	}
}

void FOClient::FormatTags(char* text, size_t text_len, CritterCl* player, CritterCl* npc, const char* lexems)
{
	if (Str::CompareCase(text, "error"))
	{
		Str::Copy(text, text_len, "Text not found!");
		return;
	}

	char* str = text;
	vector<char*> dialogs;
	int sex = 0;
	bool sex_tags = false;
	char tag[MAX_FOTEXT];
	tag[0] = 0;

	for (int i = 0; str[i];)
	{
		switch (str[i])
		{
		case '#':
		{
			str[i] = '\n';
			break;
		}
		case '|':
		{
			if (sex_tags)
			{
				Str::CopyWord(tag, &str[i + 1], '|', false);
				Str::EraseInterval(&str[i], Str::Length(tag) + 2);

				if (sex)
				{
					if (sex == 1)
					{
						if (Str::Length(str) + Str::Length(tag) < text_len)
							Str::Insert(&str[i], tag);
						// i+=strlen(tag);
					}
					sex--;
				}
				continue;
			}
			break;
		}
		case '@':
		{
			if (str[i + 1] == '@')
			{
				str[i] = 0;
				dialogs.push_back(str);
				str = &str[i + 2];
				i = 0;
				continue;
			}

			tag[0] = 0;
			Str::CopyWord(tag, &str[i + 1], '@', false);
			Str::EraseInterval(&str[i], Str::Length(tag) + 2);

			if (!Str::Length(tag))
				break;

			// Player name
			if (Str::CompareCase(tag, "pname"))
			{
				Str::Copy(tag, player ? player->GetName() : "");
			}
			// Npc name
			else if (Str::CompareCase(tag, "nname"))
			{
				Str::Copy(tag, npc ? npc->GetName() : "");
			}
			// Sex
			else if (Str::CompareCase(tag, "sex"))
			{
				sex = (player ? player->GetParam(ST_GENDER) + 1 : 1);
				sex_tags = true;
				continue;
			}
			// Lexems
			else if (Str::Length(tag) > 4 && tag[0] == 'l' && tag[1] == 'e' && tag[2] == 'x' && tag[3] == ' ')
			{
				const char* s = Str::Substring(lexems ? lexems : "", Str::FormatBuf("$%s", &tag[4]));
				if (s)
				{
					s += Str::Length(&tag[4]) + 1;
					if (*s == ' ')
						s++;
					Str::CopyWord(tag, s, '$', false);
				}
				else
				{
					Str::Copy(tag, "<lexem not found>");
				}
			}
			// Msg text
			else if (Str::Length(tag) > 4 && tag[0] == 'm' && tag[1] == 's' && tag[2] == 'g' && tag[3] == ' ')
			{
				char msg_type_name[64];
				uint str_num;
				Str::EraseChars(&tag[4], '(');
				Str::EraseChars(&tag[4], ')');
				if (sscanf(&tag[4], "%s %u", msg_type_name, &str_num) != 2)
				{
					Str::Copy(tag, "<msg tag parse fail>");
				}
				else
				{
					int msg_type = FOMsg::GetMsgType(msg_type_name);
					if (msg_type < 0 || msg_type >= TEXTMSG_MAX)
						Str::Copy(tag, "<msg tag, unknown type>");
					else if (!CurLang.Msg[msg_type].Count(str_num))
						Str::Copy(tag, Str::FormatBuf("<msg tag, string %u not found>", str_num));
					else
						Str::Copy(tag, CurLang.Msg[msg_type].GetStr(str_num));
				}
			}
			// Script
			else if (Str::Length(tag) > 7 && tag[0] == 's' && tag[1] == 'c' && tag[2] == 'r' && tag[3] == 'i' && tag[4] == 'p' && tag[5] == 't' && tag[6] == ' ')
			{
				char func_name[MAX_FOTEXT];
				Str::CopyWord(func_name, &tag[7], '$', false);
				int bind_id = Script::Bind("client_main", func_name, "string %s(string&)", true);
				Str::Copy(tag, "<script function not found>");
				if (bind_id > 0 && Script::PrepareContext(bind_id, _FUNC_, "Game"))
				{
					ScriptString* script_lexems = new ScriptString(lexems ? lexems : "");
					Script::SetArgObject(script_lexems);
					if (Script::RunPrepared())
					{
						ScriptString* result = (ScriptString*)Script::GetReturnedObject();
						if (result)
							Str::Copy(tag, result->c_str());
					}
					script_lexems->Release();
				}
			}
			// Error
			else
			{
				Str::Copy(tag, "<error>");
			}

			if (Str::Length(str) + Str::Length(tag) < text_len)
				Str::Insert(str + i, tag);
		}
		continue;
		default:
			break;
		}

		++i;
	}

	dialogs.push_back(str);
	Str::Copy(text, text_len, dialogs[Random(0, (uint)dialogs.size() - 1)]);
}


