﻿using GTANetworkAPI;
using WiredPlayers.globals;
using WiredPlayers.messages.error;

namespace WiredPlayers.character
{
    public class Animations : Script
    {
        [Command(Commands.COM_GRAB)]
        public void GrabCommand(Client player)
        {
            if (player.GetSharedData(EntityData.PLAYER_KILLED) != 0)
            {
                player.SendChatMessage(Constants.COLOR_ERROR + ErrRes.player_is_dead);
            }
            else
            {
                player.StopAnimation();
                player.PlayAnimation("anim@heists@money_grab@duffel", "loop", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
            }
        }

        [Command(Commands.COM_FACEPALM)]
        public void FacepalmCommand(Client player)
        {
            if (player.GetSharedData(EntityData.PLAYER_KILLED) != 0)
            {
                player.SendChatMessage(Constants.COLOR_ERROR + ErrRes.player_is_dead);
            }
            else
            {
                player.StopAnimation();
                player.PlayAnimation("anim@mp_player_intcelebrationmale@face_palm", "face_palm", (int) Constants.AnimationFlags.AllowPlayerControl);
            }
        }

        [Command(Commands.COM_LOCO)]
        public void LocoCommand(Client player)
        {
            if (player.GetSharedData(EntityData.PLAYER_KILLED) != 0)
            {
                player.SendChatMessage(Constants.COLOR_ERROR + ErrRes.player_is_dead);
            }
            else
            {
                player.StopAnimation();
                player.PlayAnimation("anim@mp_player_intcelebrationmale@you_loco", "you_loco", (int)Constants.AnimationFlags.AllowPlayerControl);
            }
        }

        [Command(Commands.COM_FREAKOUT)]
        public void FreakoutCommand(Client player)
        {
            if (player.GetSharedData(EntityData.PLAYER_KILLED) != 0)
            {
                player.SendChatMessage(Constants.COLOR_ERROR + ErrRes.player_is_dead);
            }
            else
            {
                player.StopAnimation();
                player.PlayAnimation("anim@mp_player_intcelebrationmale@freakout", "freakout", (int)Constants.AnimationFlags.AllowPlayerControl);
            }
        }

        [Command(Commands.COM_THUMB_ON_EARS)]
        public void ThumbOnEarsCommand(Client player)
        {
            if (player.GetSharedData(EntityData.PLAYER_KILLED) != 0)
            {
                player.SendChatMessage(Constants.COLOR_ERROR + ErrRes.player_is_dead);
            }
            else
            {
                player.StopAnimation();
                player.PlayAnimation("anim@mp_player_intcelebrationmale@thumb_on_ears", "thumb_on_ears", (int)Constants.AnimationFlags.AllowPlayerControl);
            }
        }

        [Command(Commands.COM_VICTORY)]
        public void VictoryCommand(Client player)
        {
            if (player.GetSharedData(EntityData.PLAYER_KILLED) != 0)
            {
                player.SendChatMessage(Constants.COLOR_ERROR + ErrRes.player_is_dead);
            }
            else
            {
                player.StopAnimation();
                player.PlayAnimation("anim@mp_player_intcelebrationmale@v_sign", "v_sign", (int)Constants.AnimationFlags.AllowPlayerControl);
            }
        }

        [Command(Commands.COM_CROUCH)]
        public void CrouchCommand(Client player)
        {
            if (player.GetSharedData(EntityData.PLAYER_KILLED) != 0)
            {
                player.SendChatMessage(Constants.COLOR_ERROR + ErrRes.player_is_dead);
            }
            else
            {
                player.StopAnimation();
                player.PlayAnimation("misscarstealfinalecar_5_ig_3", "crouchloop", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
            }
        }

        [Command(Commands.COM_DJ)]
        public void DjCommand(Client player)
        {
            if (player.GetSharedData(EntityData.PLAYER_KILLED) != 0)
            {
                player.SendChatMessage(Constants.COLOR_ERROR + ErrRes.player_is_dead);
            }
            else
            {
                player.StopAnimation();
                player.PlayAnimation("anim@mp_player_intupperdj", "enter", (int)Constants.AnimationFlags.AllowPlayerControl);
            }
        }

        [Command(Commands.COM_KNEEL)]
        public void KneelCommand(Client player)
        {
            if (player.GetSharedData(EntityData.PLAYER_KILLED) != 0)
            {
                player.SendChatMessage(Constants.COLOR_ERROR + ErrRes.player_is_dead);
            }
            else
            {
                player.StopAnimation();
                player.PlayAnimation("amb@medic@standing@kneel@base", "base", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
            }
        }

        [Command(Commands.COM_SPEAK)]
        public void SpeakCommand(Client player)
        {
            if (player.GetSharedData(EntityData.PLAYER_KILLED) != 0)
            {
                player.SendChatMessage(Constants.COLOR_ERROR + ErrRes.player_is_dead);
            }
            else
            {
                player.StopAnimation();
                player.PlayAnimation("amb@code_human_police_crowd_control@idle_a", "idle_b", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
            }
        }

        [Command(Commands.COM_MECHANIC, Commands.HLP_ANIMS_MECHANIC)]
        public void MechanicCommand(Client player, int action)
        {
            if (player.GetSharedData(EntityData.PLAYER_KILLED) != 0)
            {
                player.SendChatMessage(Constants.COLOR_ERROR + ErrRes.player_is_dead);
            }
            else
            {
                switch (action)
                {
                    case 1:
                        player.StopAnimation();
                        player.PlayAnimation("amb@world_human_vehicle_mechanic@male@idle_a", "idle_a", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 2:
                        player.StopAnimation();
                        player.PlayAnimation("mini@repair", "fixing_a_ped", (int)Constants.AnimationFlags.Loop);
                        break;
                    case 3:
                        player.StopAnimation();
                        player.PlayAnimation("missheistdockssetup1ig_10@laugh", "laugh_pipe_worker1", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    default:
                        player.SendChatMessage(Constants.COLOR_HELP + Commands.HLP_ANIMS_MECHANIC);
                        break;
                }
            }
        }

        [Command(Commands.COM_DIG)]
        public void DigCommand(Client player)
        {
            if (player.GetSharedData(EntityData.PLAYER_KILLED) != 0)
            {
                player.SendChatMessage(Constants.COLOR_ERROR + ErrRes.player_is_dead);
            }
            else
            {
                player.StopAnimation();
                player.PlayAnimation("missmic1leadinoutmic_1_mcs_2", "_leadin_trevor", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
            }
        }

        [Command(Commands.COM_CRY)]
        public void CryCommand(Client player)
        {
            if (player.GetSharedData(EntityData.PLAYER_KILLED) != 0)
            {
                player.SendChatMessage(Constants.COLOR_ERROR + ErrRes.player_is_dead);
            }
            else
            {
                player.StopAnimation();
                player.PlayAnimation("mp_bank_heist_1", "f_cower_01", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
            }
        }

        [Command(Commands.COM_CLEAN, Commands.HLP_ANIMS_CLEAN)]
        public void CleanCommand(Client player, int action)
        {
            if (player.GetSharedData(EntityData.PLAYER_KILLED) != 0)
            {
                player.SendChatMessage(Constants.COLOR_ERROR + ErrRes.player_is_dead);
            }
            else
            {
                switch (action)
                {
                    case 1:
                        player.StopAnimation();
                        player.PlayAnimation("switch@franklin@cleaning_car", "001946_01_gc_fras_v2_ig_5_base", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 2:
                        player.StopAnimation();
                        player.PlayAnimation("timetable@maid@cleaning_window@base", "base", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 3:
                        player.StopAnimation();
                        player.PlayAnimation("missheistdocks2bleadinoutlsdh_2b_int", "leg_massage_b_floyd", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 4:
                        player.StopAnimation();
                        player.PlayAnimation("missfbi_s4mop", "idle_scrub", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 5:
                        player.StopAnimation();
                        player.PlayAnimation("amb@world_human_bum_wash@male@low@idle_a", "idle_c", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    default:
                        player.SendChatMessage(Constants.COLOR_HELP + Commands.HLP_ANIMS_CLEAN);
                        break;
                }
            }
        }

        [Command(Commands.COM_SHOWER, Commands.HLP_ANIMS_SHOWER)]
        public void ShowerCommand(Client player, int action)
        {
            if (player.GetSharedData(EntityData.PLAYER_KILLED) != 0)
            {
                player.SendChatMessage(Constants.COLOR_ERROR + ErrRes.player_is_dead);
            }
            else
            {
                switch (action)
                {
                    case 1:
                        player.StopAnimation();
                        player.PlayAnimation("anim@mp_yacht@shower@male@", "male_shower_idle_d", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 2:
                        player.StopAnimation();
                        player.PlayAnimation("anim@mp_yacht@shower@female@", "shower_idle_a", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    default:
                        player.SendChatMessage(Constants.COLOR_HELP + Commands.HLP_ANIMS_SHOWER);
                        break;
                }
            }
        }

        [Command(Commands.COM_HURRY_UP)]
        public void HurryUpCommand(Client player)
        {
            if (player.GetSharedData(EntityData.PLAYER_KILLED) != 0)
            {
                player.SendChatMessage(Constants.COLOR_ERROR + ErrRes.player_is_dead);
            }
            else
            {
                player.StopAnimation();
                player.PlayAnimation("missfam4", "say_hurry_up_a_trevor", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
            }
        }

        [Command(Commands.COM_SPORTS, Commands.HLP_ANIMS_SPORTS)]
        public void SportsCommand(Client player, int action)
        {
            if (player.GetSharedData(EntityData.PLAYER_KILLED) != 0)
            {
                player.SendChatMessage(Constants.COLOR_ERROR + ErrRes.player_is_dead);
            }
            else
            {
                switch (action)
                {
                    case 1:
                        player.StopAnimation();
                        player.PlayAnimation("rcmcollect_paperleadinout@", "meditiate_idle", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 2:
                        player.StopAnimation();
                        player.PlayAnimation("timetable@reunited@ig_2", "jimmy_masterbation", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 3:
                        player.StopAnimation();
                        player.PlayAnimation("timetable@reunited@ig_2", "jimmy_base", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 4:
                        player.StopAnimation();
                        player.PlayAnimation("move_m@jog@", "run", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 5:
                        player.StopAnimation();
                        player.PlayAnimation("move_f@jogger", "jogging", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 6:
                        player.StopAnimation();
                        player.PlayAnimation("amb@world_human_jog@female@base", "base", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 7:
                        player.StopAnimation();
                        player.PlayAnimation("mini@triathlon", "idle_a", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 8:
                        player.StopAnimation();
                        player.PlayAnimation("mini@triathlon", "idle_d", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 9:
                        player.StopAnimation();
                        player.PlayAnimation("mini@triathlon", "idle_e", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 10:
                        player.StopAnimation();
                        player.PlayAnimation("mini@triathlon", "idle_f", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 11:
                        player.StopAnimation();
                        player.PlayAnimation("amb@world_human_yoga@female@base", "base_a", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 12:
                        player.StopAnimation();
                        player.PlayAnimation("amb@world_human_yoga@female@base", "base_c", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 13:
                        player.StopAnimation();
                        player.PlayAnimation("amb@world_human_yoga@male@base", "base_b", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 14:
                        player.StopAnimation();
                        player.PlayAnimation("amb@world_human_push_ups@male@idle_a", "idle_d", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 15:
                        player.StopAnimation();
                        player.PlayAnimation("amb@world_human_sit_ups@male@base", "base", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    default:
                        player.SendChatMessage(Constants.COLOR_HELP + Commands.HLP_ANIMS_SPORTS);
                        break;
                }
            }
        }

        [Command(Commands.COM_TYPE)]
        public void TypeCommand(Client player)
        {
            if (player.GetSharedData(EntityData.PLAYER_KILLED) != 0)
            {
                player.SendChatMessage(Constants.COLOR_ERROR + ErrRes.player_is_dead);
            }
            else
            {
                player.StopAnimation();
                player.PlayAnimation("mp_fbi_heist", "loop", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
            }
        }

        [Command(Commands.COM_KNOCK_DOOR)]
        public void KnockDoorCommand(Client player)
        {
            if (player.GetSharedData(EntityData.PLAYER_KILLED) != 0)
            {
                player.SendChatMessage(Constants.COLOR_ERROR + ErrRes.player_is_dead);
            }
            else
            {
                player.StopAnimation();
                player.PlayAnimation("timetable@jimmy@doorknock@", "knockdoor_idle", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
            }
        }

        [Command(Commands.COM_TAGGING)]
        public void TaggingCommand(Client player)
        {
            if (player.GetSharedData(EntityData.PLAYER_KILLED) != 0)
            {
                player.SendChatMessage(Constants.COLOR_ERROR + ErrRes.player_is_dead);
            }
            else
            {
                player.StopAnimation();
                player.PlayAnimation("switch@franklin@lamar_tagging_wall", "lamar_tagging_exit_loop_lamar", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
            }
        }

        [Command(Commands.COM_STRIPTEASE, Commands.HLP_ANIMS_STRIPTEASE)]
        public void StripteaseCommand(Client player, int action)
        {
            if (player.GetSharedData(EntityData.PLAYER_KILLED) != 0)
            {
                player.SendChatMessage(Constants.COLOR_ERROR + ErrRes.player_is_dead);
            }
            else
            {
                switch (action)
                {
                    case 1:
                        player.StopAnimation();
                        player.PlayAnimation("mini@strip_club@pole_dance@pole_a_2_stage", "pole_a_2_stage", (int)(Constants.AnimationFlags.StopOnLastFrame | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 2:
                        player.StopAnimation();
                        player.PlayAnimation("mini@strip_club@pole_dance@pole_b_2_stage", "pole_b_2_stage", (int)(Constants.AnimationFlags.StopOnLastFrame | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 3:
                        player.StopAnimation();
                        player.PlayAnimation("mini@strip_club@pole_dance@pole_c_2_prvd_a", "pole_c_2_prvd_a", (int)(Constants.AnimationFlags.StopOnLastFrame | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 4:
                        player.StopAnimation();
                        player.PlayAnimation("mini@strip_club@pole_dance@pole_c_2_prvd_b", "pole_c_2_prvd_b", (int)(Constants.AnimationFlags.StopOnLastFrame | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 5:
                        player.StopAnimation();
                        player.PlayAnimation("mini@hookers_spcrackhead", "idle_b", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 6:
                        player.StopAnimation();
                        player.PlayAnimation("mini@strip_club@pole_dance@pole_c_2_prvd_c", "pole_c_2_prvd_c", (int)(Constants.AnimationFlags.StopOnLastFrame | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 7:
                        player.StopAnimation();
                        player.PlayAnimation("mini@strip_club@pole_dance@pole_dance1", "pd_dance_01", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 8:
                        player.StopAnimation();
                        player.PlayAnimation("mini@strip_club@pole_dance@pole_dance2", "pd_dance_02", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 9:
                        player.StopAnimation();
                        player.PlayAnimation("mini@strip_club@pole_dance@pole_dance3", "pd_dance_03", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 10:
                        player.StopAnimation();
                        player.PlayAnimation("mini@strip_club@pole_dance@pole_enter", "pd_enter", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 11:
                        player.StopAnimation();
                        player.PlayAnimation("mini@strip_club@pole_dance@pole_exit", "pd_exit", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 12:
                        player.StopAnimation();
                        player.PlayAnimation("mini@strip_club@private_dance@exit", "priv_dance_exit", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 13:
                        player.StopAnimation();
                        player.PlayAnimation("mini@strip_club@private_dance@idle", "priv_dance_idle", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 14:
                        player.StopAnimation();
                        player.PlayAnimation("mp_am_stripper", "lap_dance_girl", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    default:
                        player.SendChatMessage(Constants.COLOR_HELP + Commands.HLP_ANIMS_STRIPTEASE);
                        break;
                }
            }
        }

        [Command(Commands.COM_DRINK)]
        public void DrinkCommand(Client player)
        {
            if (player.GetSharedData(EntityData.PLAYER_KILLED) != 0)
            {
                player.SendChatMessage(Constants.COLOR_ERROR + ErrRes.player_is_dead);
            }
            else
            {
                player.StopAnimation();
                player.PlayAnimation("amb@world_human_drinking_fat@beer@male@idle_a", "idle_a", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
            }
        }

        [Command(Commands.COM_KISS)]
        public void KissCommand(Client player, int action)
        {
            if (player.GetSharedData(EntityData.PLAYER_KILLED) != 0)
            {
                player.SendChatMessage(Constants.COLOR_ERROR + ErrRes.player_is_dead);
            }
            else
            {
                player.StopAnimation();
                player.PlayAnimation("mini@hookers_sp", "idle_a", (int)Constants.AnimationFlags.AllowPlayerControl);
            }
        }

        [Command(Commands.COM_AIM)]
        public void AimCommand(Client player, int action)
        {
            if (player.GetSharedData(EntityData.PLAYER_KILLED) != 0)
            {
                player.SendChatMessage(Constants.COLOR_ERROR + ErrRes.player_is_dead);
            }
            else
            {
                player.StopAnimation();
                player.PlayAnimation("combat@chg_stance", "aima_loop", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
            }
        }

        [Command(Commands.COM_SALUTE, Commands.HLP_ANIMS_SALUTE)]
        public void SaluteCommand(Client player, int action)
        {
            if (player.GetSharedData(EntityData.PLAYER_KILLED) != 0)
            {
                player.SendChatMessage(Constants.COLOR_ERROR + ErrRes.player_is_dead);
            }
            else
            {
                switch (action)
                {
                    case 1:
                        player.StopAnimation();
                        player.PlayAnimation("mp_player_int_uppersalute", "mp_player_int_salute", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 2:
                        player.StopAnimation();
                        player.PlayAnimation("mp_ped_interaction", "hugs_guy_a", (int)Constants.AnimationFlags.AllowPlayerControl);
                        break;
                    case 3:
                        player.StopAnimation();
                        player.PlayAnimation("mp_player_intsalute", "mp_player_int_salute", (int)Constants.AnimationFlags.AllowPlayerControl);
                        break;
                    case 4:
                        player.StopAnimation();
                        player.PlayAnimation("missmic4premiere", "crowd_a_idle_01", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 5:
                        player.StopAnimation();
                        player.PlayAnimation("missexile2", "franklinwavetohelicopter", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 6:
                        player.StopAnimation();
                        player.PlayAnimation("anim@mp_player_intcelebrationmale@wave", "wave", (int)Constants.AnimationFlags.AllowPlayerControl);
                        break;
                    default:
                        player.StopAnimation();
                        player.SendChatMessage(Constants.COLOR_HELP + Commands.HLP_ANIMS_SALUTE);
                        break;
                }
            }
        }

        [Command(Commands.COM_FUCKU)]
        public void FuckUCommand(Client player)
        {
            if (player.GetSharedData(EntityData.PLAYER_KILLED) != 0)
            {
                player.SendChatMessage(Constants.COLOR_ERROR + ErrRes.player_is_dead);
            }
            else
            {
                player.StopAnimation();
                player.PlayAnimation("anim@mp_player_intselfiethe_bird", "idle_a", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl | Constants.AnimationFlags.OnlyAnimateUpperBody));
            }
        }

        [Command(Commands.COM_WALK, Commands.HLP_ANIMS_WALK)]
        public void WalkCommand(Client player, int action)
        {
            if (player.GetSharedData(EntityData.PLAYER_KILLED) != 0)
            {
                player.SendChatMessage(Constants.COLOR_ERROR + ErrRes.player_is_dead);
            }
            else
            {
                switch (action)
                {
                    case 1:
                        player.StopAnimation();
                        player.PlayAnimation("move_f@heels@c", "walk", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 2:
                        player.StopAnimation();
                        player.PlayAnimation("move_f@arrogant@a", "walk", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 3:
                        player.StopAnimation();
                        player.PlayAnimation("move_f@sad@a", "walk", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 4:
                        player.StopAnimation();
                        player.PlayAnimation("move_m@drunk@moderatedrunk", "walk", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 5:
                        player.StopAnimation();
                        player.PlayAnimation("move_m@shadyped@a", "walk", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 6:
                        player.StopAnimation();
                        player.PlayAnimation("move_f@gangster@ng", "walk", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 7:
                        player.StopAnimation();
                        player.PlayAnimation("move_f@generic", "walk", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 8:
                        player.StopAnimation();
                        player.PlayAnimation("move_f@heels@d", "walk", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 9:
                        player.StopAnimation();
                        player.PlayAnimation("move_f@posh@", "walk", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 10:
                        player.StopAnimation();
                        player.PlayAnimation("move_m@brave@b", "walk", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 11:
                        player.StopAnimation();
                        player.PlayAnimation("move_m@confident", "walk", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 12:
                        player.StopAnimation();
                        player.PlayAnimation("move_m@depressed@d", "walk", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 13:
                        player.StopAnimation();
                        player.PlayAnimation("move_m@favor_right_foot", "walk", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 14:
                        player.StopAnimation();
                        player.PlayAnimation("move_m@generic", "walk", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 15:
                        player.StopAnimation();
                        player.PlayAnimation("move_m@generic_variations@walk", "walk_a", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 16:
                        player.StopAnimation();
                        player.PlayAnimation("move_m@generic_variations@walk", "walk_f", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 17:
                        player.StopAnimation();
                        player.PlayAnimation("move_m@golfer@", "golf_walk", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 18:
                        player.StopAnimation();
                        player.PlayAnimation("move_m@money", "walk", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 19:
                        player.StopAnimation();
                        player.PlayAnimation("move_m@shadyped@a", "walk", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 20:
                        player.StopAnimation();
                        player.PlayAnimation("move_m@swagger@b", "walk", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 21:
                        player.StopAnimation();
                        player.PlayAnimation("switch@franklin@dispensary", "exit_dispensary_outro_ped_f_a", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    default:
                        player.SendChatMessage(Constants.COLOR_HELP + Commands.HLP_ANIMS_WALK);
                        break;
                }
            }
        }

        [Command(Commands.COM_KNUCKLES)]
        public void KnucklesCommand(Client player)
        {
            if (player.GetSharedData(EntityData.PLAYER_KILLED) != 0)
            {
                player.SendChatMessage(Constants.COLOR_ERROR + ErrRes.player_is_dead);
            }
            else
            {
                player.StopAnimation();
                player.PlayAnimation("anim@mp_player_intupperknuckle_crunch", "idle_a", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl | Constants.AnimationFlags.OnlyAnimateUpperBody));
            }
        }

        [Command(Commands.COM_SURRENDER, Commands.HLP_ANIMS_SURRENDER)]
        public void SurrenderCommand(Client player, int action)
        {
            if (player.GetSharedData(EntityData.PLAYER_KILLED) != 0)
            {
                player.SendChatMessage(Constants.COLOR_ERROR + ErrRes.player_is_dead);
            }
            else
            {
                switch (action)
                {
                    case 1:
                        player.StopAnimation();
                        player.PlayAnimation("mp_am_hold_up", "handsup_base", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl | Constants.AnimationFlags.OnlyAnimateUpperBody));
                        break;
                    case 2:
                        player.StopAnimation();
                        player.PlayAnimation("anim@mp_player_intuppersurrender", "idle_a_fp", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl | Constants.AnimationFlags.OnlyAnimateUpperBody));
                        break;
                    case 3:
                        player.StopAnimation();
                        player.PlayAnimation("amb@code_human_cower@female@react_cowering", "base_back_left", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl | Constants.AnimationFlags.OnlyAnimateUpperBody));
                        break;
                    case 4:
                        player.StopAnimation();
                        player.PlayAnimation("amb@code_human_cower@female@react_cowering", "base_right", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl | Constants.AnimationFlags.OnlyAnimateUpperBody));
                        break;
                    case 5:
                        player.StopAnimation();
                        player.PlayAnimation("missfbi5ig_0", "lyinginpain_loop_steve", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 6:
                        player.StopAnimation();
                        player.PlayAnimation("missfbi5ig_10", "lift_holdup_loop_labped", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 7:
                        player.StopAnimation();
                        player.PlayAnimation("missfbi5ig_17", "walk_in_aim_loop_scientista", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 8:
                        player.StopAnimation();
                        player.PlayAnimation("mp_am_hold_up", "cower_loop", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 9:
                        player.StopAnimation();
                        player.PlayAnimation("mp_arrest_paired", "crook_p1_idle", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 10:
                        player.StopAnimation();
                        player.PlayAnimation("mp_bank_heist_1", "m_cower_02", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 11:
                        player.StopAnimation();
                        player.PlayAnimation("misstrevor1", "threaten_ortega_endloop_ort", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    default:
                        player.SendChatMessage(Constants.COLOR_HELP + Commands.HLP_ANIMS_SURRENDER);
                        break;
                }
            }
        }

        [Command(Commands.COM_EAT)]
        public void EatCommand(Client player)
        {
            if (player.GetSharedData(EntityData.PLAYER_KILLED) != 0)
            {
                player.SendChatMessage(Constants.COLOR_ERROR + ErrRes.player_is_dead);
            }
            else
            {
                player.StopAnimation();
                player.PlayAnimation("mp_player_inteat@burger", "mp_player_int_eat_burger", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl | Constants.AnimationFlags.OnlyAnimateUpperBody));
            }
        }

        [Command(Commands.COM_PUKE)]
        public void PukeCommand(Client player)
        {
            if (player.GetSharedData(EntityData.PLAYER_KILLED) != 0)
            {
                player.SendChatMessage(Constants.COLOR_ERROR + ErrRes.player_is_dead);
            }
            else
            {
                player.StopAnimation();
                player.PlayAnimation("missheistpaletoscore1leadinout", "trv_puking_leadout", (int)Constants.AnimationFlags.AllowPlayerControl);
            }
        }

        [Command(Commands.COM_PLANT)]
        public void PlantCommand(Client player)
        {
            if (player.GetSharedData(EntityData.PLAYER_KILLED) != 0)
            {
                player.SendChatMessage(Constants.COLOR_ERROR + ErrRes.player_is_dead);
            }
            else
            {
                player.StopAnimation();
                player.PlayAnimation("amb@world_human_gardener_plant@male@idle_a", "idle_a", (int)Constants.AnimationFlags.AllowPlayerControl);
            }
        }

        [Command(Commands.COM_CPR, Commands.HLP_ANIMS_CPR)]
        public void CprCommand(Client player, int action)
        {
            if (player.GetSharedData(EntityData.PLAYER_KILLED) != 0)
            {
                player.SendChatMessage(Constants.COLOR_ERROR + ErrRes.player_is_dead);
            }
            else
            {
                switch (action)
                {
                    case 1:
                        player.StopAnimation();
                        player.PlayAnimation("mini@cpr@char_a@cpr_def", "cpr_intro", (int)(Constants.AnimationFlags.StopOnLastFrame | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 2:
                        player.StopAnimation();
                        player.PlayAnimation("mini@cpr@char_a@cpr_str", "cpr_kol", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 3:
                        player.StopAnimation();
                        player.PlayAnimation("mini@cpr@char_a@cpr_def", "cpr_pumpchest_idle", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 4:
                        player.StopAnimation();
                        player.PlayAnimation("mini@cpr@char_a@cpr_str", "cpr_success", (int)Constants.AnimationFlags.AllowPlayerControl);
                        break;
                    default:
                        player.SendChatMessage(Constants.COLOR_HELP + Commands.HLP_ANIMS_CPR);
                        break;
                }
            }
        }

        [Command(Commands.COM_CAR_SEX, Commands.HLP_ANIMS_CAR_SEX)]
        public void CarSexCommand(Client player, int action)
        {
            if (player.GetSharedData(EntityData.PLAYER_KILLED) != 0)
            {
                player.SendChatMessage(Constants.COLOR_ERROR + ErrRes.player_is_dead);
            }
            else if (!player.IsInVehicle)
            {
                player.SendChatMessage(Constants.COLOR_ERROR + ErrRes.not_in_vehicle);
            }
            else
            {
                uint vehicleModel = player.Vehicle.GetData(EntityData.VEHICLE_MODEL);

                if (NAPI.Vehicle.GetVehicleClass((VehicleHash)vehicleModel) == Constants.VEHICLE_CLASS_CYCLES || NAPI.Vehicle.GetVehicleClass((VehicleHash)vehicleModel) == Constants.VEHICLE_CLASS_MOTORCYCLES || NAPI.Vehicle.GetVehicleClass((VehicleHash)vehicleModel) == Constants.VEHICLE_CLASS_BOATS)
                {
                    player.SendChatMessage(Constants.COLOR_ERROR + ErrRes.player_not_car);
                }
                else
                {
                    switch (action)
                    {
                        case 1:
                            if (player.VehicleSeat != (int)VehicleSeat.Driver)
                            {
                                player.SendChatMessage(Constants.COLOR_ERROR + ErrRes.not_vehicle_driving);
                            }
                            else
                            {
                                player.StopAnimation();
                                player.PlayAnimation("mini@prostitutes@sexnorm_veh", "bj_loop_male", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                            }
                            break;
                        case 2:
                            if (player.VehicleSeat != (int)VehicleSeat.Driver)
                            {
                                player.SendChatMessage(Constants.COLOR_ERROR + ErrRes.not_vehicle_driving);
                            }
                            else
                            {
                                player.StopAnimation();
                                player.PlayAnimation("mini@prostitutes@sexnorm_veh", "sex_loop_male", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                            }
                            break;
                        case 3:
                            if (player.VehicleSeat != (int)VehicleSeat.RightFront)
                            {
                                player.SendChatMessage(Constants.COLOR_ERROR + ErrRes.not_vehicle_passenger);
                            }
                            else
                            {
                                player.StopAnimation();
                                player.PlayAnimation("mini@prostitutes@sexnorm_veh", "sex_loop_prostitute", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                            }
                            break;
                        case 4:
                            if (player.VehicleSeat != (int)VehicleSeat.Driver)
                            {
                                player.SendChatMessage(Constants.COLOR_ERROR + ErrRes.not_vehicle_driving);
                            }
                            else
                            {
                                player.StopAnimation();
                                player.PlayAnimation("mini@prostitutes@sexlow_veh", "low_car_bj_loop_player", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                            }
                            break;
                        case 5:
                            if (player.VehicleSeat != (int)VehicleSeat.RightFront)
                            {
                                player.SendChatMessage(Constants.COLOR_ERROR + ErrRes.not_vehicle_passenger);
                            }
                            else
                            {
                                player.StopAnimation();
                                player.PlayAnimation("mini@prostitutes@sexlow_veh", "low_car_bj_loop_female", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                            }
                            break;
                        case 6:
                            if (player.VehicleSeat != (int)VehicleSeat.RightFront)
                            {
                                player.SendChatMessage(Constants.COLOR_ERROR + ErrRes.not_vehicle_passenger);
                            }
                            else
                            {
                                player.StopAnimation();
                                player.PlayAnimation("mini@prostitutes@sexlow_veh", "low_car_sex_loop_female", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                            }
                            break;
                        default:
                            player.SendChatMessage(Constants.COLOR_HELP + Commands.HLP_ANIMS_CAR_SEX);
                            break;
                    }
                }
            }
        }

        [Command(Commands.COM_SEXY_DANCE, Commands.HLP_ANIMS_SEXY_DANCE)]
        public void SexyDanceCommand(Client player, int action)
        {
            if (player.GetSharedData(EntityData.PLAYER_KILLED) != 0)
            {
                player.SendChatMessage(Constants.COLOR_ERROR + ErrRes.player_is_dead);
            }
            else
            {
                switch (action)
                {
                    case 1:
                        player.StopAnimation();
                        player.PlayAnimation("amb@world_human_prostitute@cokehead@idle_a", "idle_b", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 2:
                        player.StopAnimation();
                        player.PlayAnimation("mini@hookers_sp", "ilde_c", (int)Constants.AnimationFlags.AllowPlayerControl);
                        break;
                    case 3:
                        player.StopAnimation();
                        player.PlayAnimation("mini@hookers_spcokehead", "idle_a", (int)Constants.AnimationFlags.AllowPlayerControl);
                        break;
                    case 4:
                        player.StopAnimation();
                        player.PlayAnimation("mini@hookers_spcokehead", "idle_c", (int)Constants.AnimationFlags.AllowPlayerControl);
                        break;
                    case 5:
                        player.StopAnimation();
                        player.PlayAnimation("mini@hookers_spcrackhead", "idle_b", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 6:
                        player.StopAnimation();
                        player.PlayAnimation("mini@hookers_spvanilla", "idle_b", (int)Constants.AnimationFlags.AllowPlayerControl);
                        break;
                    default:
                        player.SendChatMessage(Constants.COLOR_HELP + Commands.HLP_ANIMS_SEXY_DANCE);
                        break;
                }
            }
        }

        [Command(Commands.COM_SIT, Commands.HLP_ANIMS_SIT)]
        public void SitCommand(Client player, int action)
        {
            if (player.GetSharedData(EntityData.PLAYER_KILLED) != 0)
            {
                player.SendChatMessage(Constants.COLOR_ERROR + ErrRes.player_is_dead);
            }
            else
            {
                switch (action)
                {
                    case 1:
                        player.StopAnimation();
                        player.PlayAnimation("amb@world_human_stupor@male@base", "base", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 2:
                        player.StopAnimation();
                        player.PlayAnimation("amb@world_human_stupor@male_looking_left@base", "base", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 3:
                        player.StopAnimation();
                        player.PlayAnimation("anim@heists@fleeca_bank@ig_7_jetski_owner", "owner_idle", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 4:
                        player.StopAnimation();
                        player.PlayAnimation("mp_army_contact", "positive_a", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 5:
                        player.StopAnimation();
                        player.PlayAnimation("timetable@reunited@ig_10", "base_amanda", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 6:
                        player.StopAnimation();
                        player.PlayAnimation("anim@heists@prison_heistunfinished_biztarget_idle", "target_idle", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 7:
                        player.StopAnimation();
                        player.PlayAnimation("switch@michael@sitting", "idle", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 8:
                        player.StopAnimation();
                        player.PlayAnimation("timetable@michael@on_sofaidle_c", "sit_sofa_g", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 9:
                        player.StopAnimation();
                        player.PlayAnimation("timetable@michael@on_sofaidle_b", "sit_sofa_d", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 10:
                        player.StopAnimation();
                        player.PlayAnimation("timetable@michael@on_sofaidle_a", "sit_sofa_a", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 11:
                        player.StopAnimation();
                        player.PlayAnimation("rcm_barry3", "barry_3_sit_loop", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    default:
                        player.SendChatMessage(Constants.COLOR_HELP + Commands.HLP_ANIMS_SIT);
                        break;
                }
            }
        }

        [Command(Commands.COM_SMOKE, Commands.HLP_ANIMS_SMOKING)]
        public void SmokeCommand(Client player, int action)
        {
            if (player.GetSharedData(EntityData.PLAYER_KILLED) != 0)
            {
                player.SendChatMessage(Constants.COLOR_ERROR + ErrRes.player_is_dead);
            }
            else
            {
                switch (action)
                {
                    case 1:
                        player.StopAnimation();
                        player.PlayAnimation("amb@world_human_smoking@male@male_a@idle_a", "idle_c", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 2:
                        player.StopAnimation();
                        player.PlayAnimation("amb@world_human_smoking@female@idle_a", "idle_b", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.OnlyAnimateUpperBody | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 3:
                        player.StopAnimation();
                        player.PlayAnimation("mini@hookers_spfrench", "idle_wait", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl | Constants.AnimationFlags.OnlyAnimateUpperBody));
                        break;
                    default:
                        player.SendChatMessage(Constants.COLOR_HELP + Commands.HLP_ANIMS_SMOKING);
                        break;
                }
            }
        }

        [Command(Commands.COM_LIE_DOWN, Commands.HLP_ANIMS_LIE_DOWN)]
        public void LieDownCommand(Client player, int action)
        {
            if (player.GetSharedData(EntityData.PLAYER_KILLED) != 0)
            {
                player.SendChatMessage(Constants.COLOR_ERROR + ErrRes.player_is_dead);
            }
            else
            {
                switch (action)
                {
                    case 1:
                        player.StopAnimation();
                        player.PlayAnimation("amb@world_human_sunbathe@male@back@idle_a", "idle_a", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 2:
                        player.StopAnimation();
                        player.PlayAnimation("amb@world_human_sunbathe@female@back@idle_a", "idle_a", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 3:
                        player.StopAnimation();
                        player.PlayAnimation("amb@world_human_sunbathe@female@front@base", "base", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 4:
                        player.StopAnimation();
                        player.PlayAnimation("amb@world_human_picnic@male@base", "base", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 5:
                        player.StopAnimation();
                        player.PlayAnimation("amb@world_human_picnic@female@base", "base", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 6:
                        player.StopAnimation();
                        player.PlayAnimation("missfra0_chop_fchase", "ballasog_rollthroughtraincar_ig6_loop", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    default:
                        player.SendChatMessage(Constants.COLOR_HELP + Commands.HLP_ANIMS_LIE_DOWN);
                        break;
                }
            }
        }

        [Command(Commands.COM_ARMS, Commands.HLP_ANIMS_ARMS)]
        public void ArmsCommand(Client player, int action)
        {
            if (player.GetSharedData(EntityData.PLAYER_KILLED) != 0)
            {
                player.SendChatMessage(Constants.COLOR_ERROR + ErrRes.player_is_dead);
            }
            else
            {
                switch (action)
                {
                    case 1:
                        player.StopAnimation();
                        player.PlayAnimation("amb@world_human_hang_out_street@male_c@base", "base", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 2:
                        player.StopAnimation();
                        player.PlayAnimation("amb@world_human_hang_out_street@female_arms_crossed@idle_a", "idle_a", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 3:
                        player.StopAnimation();
                        player.PlayAnimation("mini@hookers_sp", "idle_reject_loop_c", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl | Constants.AnimationFlags.OnlyAnimateUpperBody));
                        break;
                    case 4:
                        player.StopAnimation();
                        player.PlayAnimation("mini@hookers_sp", "idle_reject", (int)(Constants.AnimationFlags.AllowPlayerControl | Constants.AnimationFlags.OnlyAnimateUpperBody));
                        break;
                    default:
                        player.SendChatMessage(Constants.COLOR_HELP + Commands.HLP_ANIMS_ARMS);
                        break;
                }
            }
        }

        [Command(Commands.COM_GUARD, Commands.HLP_ANIMS_GUARD)]
        public void GuardCommand(Client player, int action)
        {
            if (player.GetSharedData(EntityData.PLAYER_KILLED) != 0)
            {
                player.SendChatMessage(Constants.COLOR_ERROR + ErrRes.player_is_dead);
            }
            else
            {
                switch (action)
                {
                    case 1:
                        player.StopAnimation();
                        player.PlayAnimation("missbigscore1", "idle_a", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 2:
                        player.StopAnimation();
                        player.PlayAnimation("missbigscore1", "idle_base", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 3:
                        player.StopAnimation();
                        player.PlayAnimation("missbigscore1", "idle_c", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 4:
                        player.StopAnimation();
                        player.PlayAnimation("missbigscore1", "idle_e", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    default:
                        player.SendChatMessage(Constants.COLOR_HELP + Commands.HLP_ANIMS_GUARD);
                        break;
                }
            }
        }

        [Command(Commands.COM_DEAD, Commands.HLP_ANIMS_DEAD)]
        public void DeadCommand(Client player, int action)
        {
            if (player.GetSharedData(EntityData.PLAYER_KILLED) != 0)
            {
                player.SendChatMessage(Constants.COLOR_ERROR + ErrRes.player_is_dead);
            }
            else
            {
                switch (action)
                {
                    case 1:
                        player.StopAnimation();
                        player.PlayAnimation("missarmenian2", "corpse_search_exit_ped", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 2:
                        player.StopAnimation();
                        player.PlayAnimation("missarmenian2", "drunk_loop", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 3:
                        player.StopAnimation();
                        player.PlayAnimation("missfinale_c1@", "lying_dead_player0", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 4:
                        player.StopAnimation();
                        player.PlayAnimation("mp_bank_heist_1", "prone_l_loop", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 5:
                        player.StopAnimation();
                        player.PlayAnimation("missfra2", "lamar_base_idle", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    default:
                        player.SendChatMessage(Constants.COLOR_HELP + Commands.HLP_ANIMS_DEAD);
                        break;
                }
            }
        }

        [Command(Commands.COM_IDLE, Commands.HLP_ANIMS_IDLE)]
        public void IdleCommand(Client player, int action)
        {
            if (player.GetSharedData(EntityData.PLAYER_KILLED) != 0)
            {
                player.SendChatMessage(Constants.COLOR_ERROR + ErrRes.player_is_dead);
            }
            else
            {
                switch (action)
                {
                    case 1:
                        player.StopAnimation();
                        player.PlayAnimation("amb@world_human_hang_out_street@female_hold_arm@base", "base", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.OnlyAnimateUpperBody | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 2:
                        player.StopAnimation();
                        player.PlayAnimation("mini@hookers_sp", "idle_wait", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl | Constants.AnimationFlags.OnlyAnimateUpperBody));
                        break;
                    case 3:
                        player.StopAnimation();
                        player.PlayAnimation("amb@world_human_stand_impatient@female@no_sign@base", "base", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 4:
                        player.StopAnimation();
                        player.PlayAnimation("mini@hookers_spfrench", "idle_wait", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 5:
                        player.StopAnimation();
                        player.PlayAnimation("amb@world_human_hang_out_street@female_arm_side@idle_a", "idle_a", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 6:
                        player.StopAnimation();
                        player.PlayAnimation("amb@world_human_muscle_flex@arms_in_front@idle_a", "idle_b", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 7:
                        player.StopAnimation();
                        player.PlayAnimation("missfbi5leadinout", "leadin_2_fra", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 8:
                        player.StopAnimation();
                        player.PlayAnimation("amb@world_human_cop_idles@female@idle_a", "idle_d", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 9:
                        player.StopAnimation();
                        player.PlayAnimation("amb@world_human_cop_idles@male@idle_b", "idle_a", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    default:
                        player.SendChatMessage(Constants.COLOR_HELP + Commands.HLP_ANIMS_IDLE);
                        break;
                }
            }
        }

        [Command(Commands.COM_PHONE, Commands.HLP_ANIMS_TLF)]
        public void PhoneCommand(Client player, int action)
        {
            if (player.GetSharedData(EntityData.PLAYER_KILLED) != 0)
            {
                player.SendChatMessage(Constants.COLOR_ERROR + ErrRes.player_is_dead);
            }
            else
            {
                switch (action)
                {
                    case 1:
                        player.StopAnimation();
                        player.PlayAnimation("amb@world_human_stand_mobile@male@text@base", "base", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl | Constants.AnimationFlags.OnlyAnimateUpperBody));
                        break;
                    case 2:
                        player.StopAnimation();
                        player.PlayAnimation("cellphone@", "cellphone_email_read_base", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl | Constants.AnimationFlags.OnlyAnimateUpperBody));
                        break;
                    case 3:
                        player.StopAnimation();
                        player.PlayAnimation("cellphone@", "cellphone_photo_idle", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl | Constants.AnimationFlags.OnlyAnimateUpperBody));
                        break;
                    case 4:
                        player.StopAnimation();
                        player.PlayAnimation("amb@world_human_stand_mobile@female@standing@call@idle_a", "idle_a", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.OnlyAnimateUpperBody | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 5:
                        player.StopAnimation();
                        player.PlayAnimation("amb@world_human_mobile_film_shocking@female@idle_a", "idle_a", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    default:
                        player.SendChatMessage(Constants.COLOR_HELP + Commands.HLP_ANIMS_TLF);
                        break;
                }
            }
        }

        [Command(Commands.COM_LEAN, Commands.HLP_ANIMS_LEAN)]
        public void LeanCommand(Client player, int action)
        {
            if (player.GetSharedData(EntityData.PLAYER_KILLED) != 0)
            {
                player.SendChatMessage(Constants.COLOR_ERROR + ErrRes.player_is_dead);
            }
            else
            {
                switch (action)
                {
                    case 1:
                        player.StopAnimation();
                        player.PlayAnimation("amb@prop_human_bum_shopping_cart@male@idle_a", "idle_a", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 2:
                        player.StopAnimation();
                        player.PlayAnimation("anim@mp_ferris_wheel", "idle_a_player_one", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 3:
                        player.StopAnimation();
                        player.PlayAnimation("amb@prop_human_bum_shopping_cart@male@base", "base", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 4:
                        player.StopAnimation();
                        player.PlayAnimation("amb@world_human_leaning@male@wall@back@legs_crossed@idle_b", "idle_d", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 5:
                        player.StopAnimation();
                        player.PlayAnimation("amb@world_human_leaning@male@wall@back@hands_together@idle_a", "idle_c", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 6:
                        player.StopAnimation();
                        player.PlayAnimation("amb@world_human_leaning@male@wall@back@mobile@base", "base", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 7:
                        player.StopAnimation();
                        player.PlayAnimation("amb@world_human_leaning@male@wall@back@texting@base", "base", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 8:
                        player.StopAnimation();
                        player.PlayAnimation("amb@world_human_leaning@female@wall@back@mobile@base", "base", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 9:
                        player.StopAnimation();
                        player.PlayAnimation("amb@world_human_leaning@female@wall@back@texting@base", "base", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 10:
                        player.StopAnimation();
                        player.PlayAnimation("amb@world_human_leaning@female@smoke@idle_a", "idle_a", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 11:
                        player.StopAnimation();
                        player.PlayAnimation("amb@world_human_leaning@male@wall@back@foot_up@idle_b", "idle_d", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 12:
                        player.StopAnimation();
                        player.PlayAnimation("misscarsteal1car_1_ext_leadin", "base_driver1", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    default:
                        player.SendChatMessage(Constants.COLOR_HELP + Commands.HLP_ANIMS_LEAN);
                        break;
                }
            }
        }

        [Command(Commands.COM_CHEER, Commands.HLP_ANIMS_CHEER)]
        public void CheerCommand(Client player, int action)
        {
            if (player.GetSharedData(EntityData.PLAYER_KILLED) != 0)
            {
                player.SendChatMessage(Constants.COLOR_ERROR + ErrRes.player_is_dead);
            }
            else
            {
                switch (action)
                {
                    case 1:
                        player.StopAnimation();
                        player.PlayAnimation("amb@world_human_cheering@female_a", "base", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 2:
                        player.StopAnimation();
                        player.PlayAnimation("amb@world_human_cheering@female_c", "base", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 3:
                        player.StopAnimation();
                        player.PlayAnimation("amb@world_human_cheering@female_d", "base", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 4:
                        player.StopAnimation();
                        player.PlayAnimation("amb@world_human_cheering@male_a", "base", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 5:
                        player.StopAnimation();
                        player.PlayAnimation("amb@world_human_cheering@male_b", "base", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 6:
                        player.StopAnimation();
                        player.PlayAnimation("amb@world_human_cheering@male_d", "base", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 7:
                        player.StopAnimation();
                        player.PlayAnimation("amb@world_human_cheering@male_e", "base", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    default:
                        player.SendChatMessage(Constants.COLOR_HELP + Commands.HLP_ANIMS_CHEER);
                        break;
                }
            }
        }

        [Command(Commands.COM_DANCE, Commands.HLP_ANIMS_DANCE)]
        public void DanceCommand(Client player, int action)
        {
            if (player.GetSharedData(EntityData.PLAYER_KILLED) != 0)
            {
                player.SendChatMessage(Constants.COLOR_ERROR + ErrRes.player_is_dead);
            }
            else
            {
                switch (action)
                {
                    case 1:
                        player.StopAnimation();
                        player.PlayAnimation("amb@world_human_jog_standing@female@base", "base", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 2:
                        player.StopAnimation();
                        player.PlayAnimation("amb@world_human_jog_standing@female@idle_a", "idle_a", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 3:
                        player.StopAnimation();
                        player.PlayAnimation("amb@world_human_power_walker@female@static", "static", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 4:
                        player.StopAnimation();
                        player.PlayAnimation("amb@world_human_partying@female@partying_beer@base", "base", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 5:
                        player.StopAnimation();
                        player.PlayAnimation("amb@world_human_partying@female@partying_cellphone@idle_a", "idle_a", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    case 6:
                        player.StopAnimation();
                        player.PlayAnimation("amb@world_human_partying@female@partying_beer@idle_a", "idle_a", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
                        break;
                    default:
                        player.SendChatMessage(Constants.COLOR_HELP + Commands.HLP_ANIMS_DANCE);
                        break;
                }
            }
        }

        [Command(Commands.COM_PISS)]
        public void PissCommand(Client player)
        {
            if (player.GetSharedData(EntityData.PLAYER_KILLED) != 0)
            {
                player.SendChatMessage(Constants.COLOR_ERROR + ErrRes.player_is_dead);
            }
            else
            {
                player.StopAnimation();
                player.PlayAnimation("missbigscore1switch_trevor_piss", "piss_loop", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
            }
        }

        [Command(Commands.COM_APLAUSE)]
        public void AplauseCommand(Client player)
        {
            if (player.GetSharedData(EntityData.PLAYER_KILLED) != 0)
            {
                player.SendChatMessage(Constants.COLOR_ERROR + ErrRes.player_is_dead);
            }
            else
            {
                player.StopAnimation();
                player.PlayAnimation("amb@world_human_strip_watch_stand@male_a@idle_a", "idle_a", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
            }
        }

        [Command(Commands.COM_DRUNK)]
        public void DrunkCommand(Client player)
        {
            if (player.GetSharedData(EntityData.PLAYER_KILLED) != 0)
            {
                player.SendChatMessage(Constants.COLOR_ERROR + ErrRes.player_is_dead);
            }
            else
            {
                player.StopAnimation();
                player.PlayAnimation("mini@hookers_spcrackhead", "idle_c", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
            }
        }

        [Command(Commands.COM_SHRUG)]
        public void ShrugCommand(Client player)
        {
            if (player.GetSharedData(EntityData.PLAYER_KILLED) != 0)
            {
                player.SendChatMessage(Constants.COLOR_ERROR + ErrRes.player_is_dead);
            }
            else
            {
                player.StopAnimation();
                player.PlayAnimation("gestures@f@standing@casual", "gesture_shrug_hard", (int)(Constants.AnimationFlags.AllowPlayerControl | Constants.AnimationFlags.OnlyAnimateUpperBody));
            }
        }

        [Command(Commands.COM_DESPERATE)]
        public void DesperateCommand(Client player)
        {
            if (player.GetSharedData(EntityData.PLAYER_KILLED) != 0)
            {
                player.SendChatMessage(Constants.COLOR_ERROR + ErrRes.player_is_dead);
            }
            else
            {
                player.StopAnimation();
                player.PlayAnimation("misscarsteal4@toilet", "desperate_toilet_idle_a", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
            }
        }

        [Command(Commands.COM_PENSIVE)]
        public void PensiveCommand(Client player)
        {
            if (player.GetSharedData(EntityData.PLAYER_KILLED) != 0)
            {
                player.SendChatMessage(Constants.COLOR_ERROR + ErrRes.player_is_dead);
            }
            else
            {
                player.StopAnimation();
                player.PlayAnimation("misscarsteal4@aliens", "rehearsal_base_idle_director", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.OnlyAnimateUpperBody | Constants.AnimationFlags.AllowPlayerControl));
            }
        }

        [Command(Commands.COM_HANDS_HEAT)]
        public void HandsHeatCommand(Client player)
        {
            if (player.GetSharedData(EntityData.PLAYER_KILLED) != 0)
            {
                player.SendChatMessage(Constants.COLOR_ERROR + ErrRes.player_is_dead);
            }
            else
            {
                player.StopAnimation();
                player.PlayAnimation("amb@world_human_stand_fire@male@base", "base", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
            }
        }

        [Command(Commands.COM_ROCK)]
        public void RockCommand(Client player)
        {
            if (player.GetSharedData(EntityData.PLAYER_KILLED) != 0)
            {
                player.SendChatMessage(Constants.COLOR_ERROR + ErrRes.player_is_dead);
            }
            else
            {
                player.StopAnimation();
                player.PlayAnimation("anim@mp_player_intincarrockbodhi@ps@", "enter", (int)(Constants.AnimationFlags.AllowPlayerControl | Constants.AnimationFlags.OnlyAnimateUpperBody));
            }
        }

        [Command(Commands.COM_INJURED)]
        public void InjuredCommand(Client player)
        {
            if (player.GetSharedData(EntityData.PLAYER_KILLED) != 0)
            {
                player.SendChatMessage(Constants.COLOR_ERROR + ErrRes.player_is_dead);
            }
            else
            {
                player.StopAnimation();
                player.PlayAnimation("combat@damage@injured_pistol@to_writhe", "variation_b", (int)(Constants.AnimationFlags.StopOnLastFrame | Constants.AnimationFlags.AllowPlayerControl));
            }
        }

        [Command(Commands.COM_STUMBLE)]
        public void StumbleCommand(Client player)
        {
            if (player.GetSharedData(EntityData.PLAYER_KILLED) != 0)
            {
                player.SendChatMessage(Constants.COLOR_ERROR + ErrRes.player_is_dead);
            }
            else
            {
                player.StopAnimation();
                player.PlayAnimation("misscarsteal4@actor", "stumble", (int)(Constants.AnimationFlags.Loop | Constants.AnimationFlags.AllowPlayerControl));
            }
        }
    }

}
