﻿using Browsers.Models.BrowserModels;
using DavWebCreator.Server.Models.Browser;
using DavWebCreator.Server.Models.Browser.Elements;
using DavWebCreator.Server.Models.Browser.Elements.Cards;
using DavWebCreator.Server.Models.Browser.Elements.Controls;
using DavWebCreator.Server.Models.Browser.Elements.Fonts;
using DavWebCreator.Server.Models.Dummys;
using GTANetworkAPI;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace WiredPlayers.globals
{



    public class PlayerPremium : Script
    {
        public List<Browser> Browsers = new List<Browser>();

        //  List<VehicleDummy> vehicleDummys = new List<VehicleDummy>
        // {
        //  new VehicleDummy(2, "Financial", 200, 100, 50, 60, true),
        // new VehicleDummy(3, "Salary", 140, 20, 43, 50, false),
        // new VehicleDummy(4, "Banshee", 120, 30, 23, 45, false),
        // new VehicleDummy(5, "Glendale", 240, 70, 63, 85, true),
        // new VehicleDummy(6, "DavMobil", 240, 70, 63, 85, true),
        //  new VehicleDummy(6, "DavMobil2", 240, 70, 63, 85, true),
        //  new VehicleDummy(6, "DavMobil3", 240, 70, 63, 85, true),
        // new VehicleDummy(6, "DavMobil4", 240, 70, 63, 85, true)
        // };

        [RemoteEvent("SHOW_PREMIUM")]
        public void CreateExampleBoxes(Client player)
        {
            player.TriggerEvent("CLOSE_BROWSER");

            player.SetData("BrowserOpen", 1);

            Browser browser = new Browser("pPremium", BrowserType.Custom, BrowserContentAlign.Center, "100%", "100%")

            {
                BackgroundColor = "white",
                Margin = "100px 0 0 0",
            };

            BrowserCard card = new BrowserCard(BrowserCardType.HeaderAndContent,
                "<b>" + player.GetData(EntityData.PLAYER_NAME) + " (ID: " + player.GetData(EntityData.PLAYER_SQL_ID) + ")</b>", "", "")
            {
                Width = "90%",
                Height = "80%",
                TextAlign = BrowserTextAlign.left,
                ItemAlignment = BrowserContentAlign.Start,
                Image = $"package://DavWebCreator/Images/bannerocean.png",
                ScrollBarY = true,
                FlexDirection = BrowserFlexDirection.flex_lg_row,
                FlexWrap = BrowserFlexWrap.flex_wrap

            };

            Browsers.Add(browser);

            card.CardTitle.TextAlign = BrowserTextAlign.center;
            browser.AddElement(card);

            #region Your Premium

            BrowserCard goBackCard = new BrowserCard(BrowserCardType.HeaderDescriptionAndButtonWithIcon,
                "", "Go Back", "")
            {
                TextAlign = BrowserTextAlign.left,
                ItemAlignment = BrowserContentAlign.Center_small,
                FlexDirection = BrowserFlexDirection.flex_lg_row,
                FlexWrap = BrowserFlexWrap.flex_wrap,
                Width = "300px",
                Height = "210px",
                Margin = "30px",
                Row = 1
            };

            goBackCard.ContentTitle.TextAlign = BrowserTextAlign.center;
            goBackCard.ContentTitle.Margin = "8px";

            goBackCard.Image = $"package://DavWebCreator/Images/bannerocean.png";

            BrowserText goBackText = new BrowserText("<font color=#F62323><b> " + "You are not a VIP!" + "</b></font>", BrowserTextAlign.center);
            //browserText2.Margin = "0 30px 10px 0";
            goBackText.FontSize = "20px";
            goBackText.Margin = "0 0px 0 0";
            goBackText.TextAlign = BrowserTextAlign.center;

            BrowserButton checkButton = new BrowserButton("See More", "SHOW_PROFILE");
            checkButton.Width = "100px";
            checkButton.Height = "35px";
            checkButton.Margin = "15px 20px 0 0";
            checkButton.SetPredefinedButtonStyle(BrowserButtonStyle.Black_Outline);

            checkButton.TextAlign = BrowserTextAlign.center;
            checkButton.ItemAlignment = BrowserContentAlign.Center;
            checkButton.AddReturnObject(checkButton, "0");
            goBackCard.AddElement(checkButton.Id);


            goBackCard.AddElement(goBackText.Id);

            card.AddElement(goBackCard.Id);

            browser.AddElement(goBackCard);
            browser.AddElement(goBackText);

            browser.AddElement(checkButton);


            #region Your Level

            BrowserCard levelCard = new BrowserCard(BrowserCardType.HeaderDescriptionAndButtonWithIcon,
                "", "Level", "")
            {
                TextAlign = BrowserTextAlign.left,
                ItemAlignment = BrowserContentAlign.Center_small,
                FlexDirection = BrowserFlexDirection.flex_lg_row,
                FlexWrap = BrowserFlexWrap.flex_wrap,
                Width = "300px",
                Height = "210px",
                Margin = "30px",
                Row = 1
            };

            levelCard.ContentTitle.TextAlign = BrowserTextAlign.center;
            levelCard.ContentTitle.Margin = "8px";

            levelCard.Image = $"package://DavWebCreator/Images/bannerocean.png";

            BrowserText levelText = new BrowserText("<font color=#33CC33><b> " + player.GetData(EntityData.PLAYER_LEVEL) + "</b></font>", BrowserTextAlign.center);
            //browserText.Margin = "0 30px 10px 0";
            levelText.Padding = "0 0px 0 0";
            levelText.FontSize = "20px";

            levelCard.AddElement(levelText.Id);

            card.AddElement(levelCard.Id);

            browser.AddElement(levelCard);
            browser.AddElement(levelText);

            #endregion

            #region Your Bank

            BrowserCard insideCard = new BrowserCard(BrowserCardType.HeaderDescriptionAndButtonWithIcon,
                "", "Premium Status", "")
            {
                TextAlign = BrowserTextAlign.left,
                ItemAlignment = BrowserContentAlign.Center_small,
                FlexDirection = BrowserFlexDirection.flex_lg_row,
                FlexWrap = BrowserFlexWrap.flex_wrap,
                Width = "300px",
                Height = "210px",
                Margin = "30px",
                Row = 1
            };

            insideCard.ContentTitle.TextAlign = BrowserTextAlign.center;
            insideCard.ContentTitle.Margin = "8px";

            insideCard.Image = $"package://DavWebCreator/Images/bannerocean.png";

            BrowserText browserText = new BrowserText("<font color=#33CC33><b> $" + player.GetSharedData(EntityData.PLAYER_BANK) + "</b></font>", BrowserTextAlign.center);
            //browserText.Margin = "0 30px 10px 0";
            browserText.Padding = "0 0px 0 0";
            browserText.FontSize = "20px";

            insideCard.AddElement(browserText.Id);

            card.AddElement(insideCard.Id);

            browser.AddElement(insideCard);
            browser.AddElement(browserText);

            #endregion           

            browser.OpenBrowser(player);
            
            #endregion
        }

        [RemoteEvent("SHOW_PREMIUMS")]
        public void ShowPremiumDetails(Client player, params object[] args)
        {
            if (args == null)
                return;

            player.SendChatMessage("Test");

            List<BrowserEventResponse> responses = JsonConvert.DeserializeObject<List<BrowserEventResponse>>(args[0].ToString());

            BrowserEventResponse buttonResponse = responses[0];

              //player.TriggerEvent("CLOSE_BROWSER");
        }
    }
}