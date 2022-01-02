﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hearn.Midi
{
    public class MidiConstants
    {

        public enum Formats
        {
            SingleTrack = 0,
            MultiSimultaneousTracks = 1,
            MultiSequentialTracks = 2
        }

        public enum StringTypes
        {
            ArbitraryText = 0x01,
            CopyrightNotice = 0x02,
            TrackName = 0x03,
            InstrumentName = 0x04,
            Lyric = 0x05,
            Marker = 0x06,
            CuePoint = 0x07
        }

        public enum InstrumentGroups
        {
            Piano,
            ChromaticPercussion,
            Organ,
            Guitar,
            Bass,
            Strings,
            Ensemble,
            Brass,
            Reed,
            Pipe,
            Synth,
            SynthPad,
            SynthEffects,
            Ethnic,
            Percussive,
            SoundEffects
        }

        public enum Instruments
        {
            //Piano
            AcousticGrandPiano,
            BrightAcousticPiano,
            ElectricGrandPiano,
            HonkytonkPiano,
            ElectricPiano1,
            ElectricPiano2,
            Harpsichord,
            Clavi,
            //Chromatic Percussion
            Celesta,
            Glockenspiel,
            MusicBox,
            Vibraphone,
            Marimba,
            Xylophone,
            TubularBells,
            Dulcimer,
            //Organ
            DrawbarOrgan,
            PercussiveOrgan,
            RockOrgan,
            ChurchOrgan,
            ReedOrgan,
            Accordion,
            Harmonica,
            TangoAccordion,
            //Guitar
            AcousticGuitarNylon,
            AcousticGuitarSteel,
            ElectricGuitarJazz,
            ElectricGuitarClean,
            ElectricGuitarMuted,
            OverdrivenGuitar,
            DistortionGuitar,
            GuitarHarmonics,
            //Bass
            AcousticBass,
            ElectricBassFinger,
            ElectricBassPick,
            FretlessBass,
            SlapBass1,
            SlapBass2,
            SynthBass1,
            SynthBass2,
            //Strings
            Violin,
            Viola,
            Cello,
            Contrabass,
            TremoloStrings,
            PizzicatoStrings,
            OrchestralHarp,
            Timpani,
            //Ensemble
            StringEnsemble1,
            StringEnsemble2,
            SynthStrings1,
            SynthStrings2,
            ChoirAahs,
            VoiceOohs,
            SynthVoice,
            OrchestraHit,
            //Brass
            Trumpet,
            Trombone,
            Tuba,
            MutedTrumpet,
            FrenchHorn,
            BrassSection,
            SynthBrass1,
            SynthBrass2,
            //Reed
            SopranoSax,
            AltoSax,
            TenorSax,
            BaritoneSax,
            Oboe,
            EnglishHorn,
            Bassoon,
            Clarinet,
            //Pipe
            Piccolo,
            Flute,
            Recorder,
            PanFlute,
            Blownbottle,
            Shakuhachi,
            Whistle,
            Ocarina,
            //Synth
            Lead1Square,
            Lead2Sawtooth,
            Lead3Calliope,
            Lead4Chiff,
            Lead5Charang,
            Lead6Voice,
            Lead7Fifths,
            Lead8BassAndLead,
            //SynthPad
            Pad1NewAge,
            Pad2Warm,
            Pad3Polysynth,
            Pad4Choir,
            Pad5Bowed,
            Pad6Metallic,
            Pad7Halo,
            Pad8Sweep,
            //Synth Effects
            FX1Rain,
            FX2Soundtrack,
            FX3Crystal,
            FX4Atmosphere,
            FX5Brightness,
            FX6Goblins,
            FX7Echoes,
            FX8SciFi,
            //Ethnic
            Sitar,
            Banjo,
            Shamisen,
            Koto,
            Kalimba,
            Bagpipe,
            Fiddle,
            Shanai,
            //Percussive
            TinkleBell,
            Agogô,
            SteelDrums,
            Woodblock,
            TaikoDrum,
            MelodicTom,
            SynthDrum,
            ReverseCymbal,
            //Sound Effects
            GuitarFretNoise,
            BreathNoise,
            Seashore,
            BirdTweet,
            TelephoneRing,
            Helicopter,
            Applause,
            Gunshot
        }

        public enum Percussion
        {
            AcousticBassDrum = 35,
            ElectricBassDrum,
            SideStick,
            AcousticSnare,
            HandClap,
            ElectricSnare,
            LowFloorTom,
            ClosedHihat,
            HighFloorTom,
            PedalHijat,
            LowTom,
            OpenHihat,
            LowMidTom,
            HiMidTom,
            CrashCymbal1,
            HighTom,
            RideCymbal1,
            ChineseCymbal,
            RideBell,
            Tambourine,
            SplashCymbal,
            Cowbell,
            CrashCymbal2,
            VibraSlap,
            RideCymbal2,
            HighBongo,
            LowBongo,
            MuteHighConga,
            OpenHighConga,
            LowConga,
            HighTimbale,
            LowTimbale,
            HighAgogô,
            LowAgogô,
            Cabasa,
            Maracas,
            ShortWhistle,
            LongWhistle,
            ShortGuiro,
            LongGuiro,
            Claves,
            HighWoodblock,
            LowWoodblock,
            MuteCuica,
            OpenCuica,
            MuteTriangle,
            OpenTriangle
        }

        public enum MidiNoteNumbers
        {
            A0 = 21, //Key 1 on a Piano
            AS0,
            B0,

            C1,
            CSDF1,
            D1,
            DSEF1,
            E1,
            F1,
            FSGF1,
            G1,
            GSAF1,
            A1,
            ASBF1,
            B1,

            C2,
            CSDF2,
            D2,
            DSEF2,
            E2,
            F2,
            FSGF2,
            G2,
            GSAF2,
            A2,
            ASBF2,
            B2,

            C3,
            CSDF3,
            D3,
            DSEF3,
            E3,
            F3,
            FSGF3,
            G3,
            GSAF3,
            A3,
            ASBF3,
            B3,

            C4,
            CSDF4,
            D4,
            DSEF4,
            E4,
            F4,
            FSGF4,
            G4,
            GSAF4,
            A4,
            ASBF4,
            B4,

            C5,
            CSDF5,
            D5,
            DSEF5,
            E5,
            F5,
            FSGF5,
            G5,
            GSAF5,
            A5,
            ASBF5,
            B5,

            C6,
            CSDF6,
            D6,
            DSEF6,
            E6,
            F6,
            FSGF6,
            G6,
            GSAF6,
            A6,
            ASBF6,
            B6,

            C7,
            CSDF7,
            D7,
            DSEF7,
            E7,
            F7,
            FSGF7,
            G7,
            GSAF7,
            A7,
            ASBF7,
            B7,

            C8 //108 (Key 88 on Piano)

        }

        public static readonly string[] InstrumentNames = new string[128]
        {
            "Acoustic Grand Piano",
            "Bright Acoustic Piano",
            "Electric Grand Piano",
            "Honky-tonk Piano",
            "Electric Piano 1",
            "Electric Piano 2",
            "Harpsichord",
            "Clavinet",
            "Celesta",
            "Glockenspiel",
            "Music Box",
            "Vibraphone",
            "Marimba",
            "Xylophone",
            "Tubular Bells",
            "Dulcimer",
            "Drawbar Organ",
            "Percussive Organ",
            "Rock Organ",
            "Church Organ",
            "Reed Organ",
            "Accordion",
            "Harmonica",
            "Tango Accordion",
            "Acoustic Guitar (nylon)",
            "Acoustic Guitar (steel)",
            "Electric Guitar (jazz)",
            "Electric Guitar (clean)",
            "Electric Guitar (muted)",
            "Overdriven Guitar",
            "Distortion Guitar",
            "Guitar harmonics",
            "Acoustic Bass",
            "Electric Bass (finger)",
            "Electric Bass (pick)",
            "Fretless Bass",
            "Slap Bass 1",
            "Slap Bass 2",
            "Synth Bass 1",
            "Synth Bass 2",
            "Violin",
            "Viola",
            "Cello",
            "Contrabass",
            "Tremolo Strings",
            "Pizzicato Strings",
            "Orchestral Harp",
            "Timpani",
            "String Ensemble 1",
            "String Ensemble 2",
            "Synth Strings 1",
            "Synth Strings 2",
            "Choir Aahs",
            "Voice Oohs",
            "Synth Voice",
            "Orchestra Hit",
            "Trumpet",
            "Trombone",
            "Tuba",
            "Muted Trumpet",
            "French Horn",
            "Brass Section",
            "Synth Brass 1",
            "Synth Brass 2",
            "Soprano Sax",
            "Alto Sax",
            "Tenor Sax",
            "Baritone Sax",
            "Oboe",
            "English Horn",
            "Bassoon",
            "Clarinet",
            "Piccolo",
            "Flute",
            "Recorder",
            "Pan Flute",
            "Blown Bottle",
            "Shakuhachi",
            "Whistle",
            "Ocarina",
            "Lead 1 (square)",
            "Lead 2 (sawtooth)",
            "Lead 3 (calliope)",
            "Lead 4 (chiff)",
            "Lead 5 (charang)",
            "Lead 6 (voice)",
            "Lead 7 (fifths)",
            "Lead 8 (bass + lead)",
            "Pad 1 (new age)",
            "Pad 2 (warm)",
            "Pad 3 (polysynth)",
            "Pad 4 (choir)",
            "Pad 5 (bowed)",
            "Pad 6 (metallic)",
            "Pad 7 (halo)",
            "Pad 8 (sweep)",
            "FX 1 (rain)",
            "FX 2 (soundtrack)",
            "FX 3 (crystal)",
            "FX 4 (atmosphere)",
            "FX 5 (brightness)",
            "FX 6 (goblins)",
            "FX 7 (echoes)",
            "FX 8 (sci-fi)",
            "Sitar",
            "Banjo",
            "Shamisen",
            "Koto",
            "Kalimba",
            "Bag pipe",
            "Fiddle",
            "Shanai",
            "Tinkle Bell",
            "Agogo",
            "Steel Drums",
            "Woodblock",
            "Taiko Drum",
            "Melodic Tom",
            "Synth Drum",
            "Reverse Cymbal",
            "Guitar Fret Noise",
            "Breath Noise",
            "Seashore",
            "Bird Tweet",
            "Telephone Ring",
            "Helicopter",
            "Applause",
            "Gunshot"
        };

        public static readonly string[] InstrumentGroupNames = new string[16]
        {
            "Piano",
            "Chromatic Percussion",
            "Organ",
            "Guitar",
            "Bass",
            "Strings",
            "Ensemble",
            "Brass",
            "Reed",
            "Pipe",
            "Synth",
            "Synth Pad",
            "Synth Effects",
            "Ethnic",
            "Percussive",
            "Sound Effects"
        };

        public static readonly InstrumentGroups[] InstrumentGroupings = new InstrumentGroups[128]
        {
            //Piano
            InstrumentGroups.Piano, //AcousticGrandPiano,
            InstrumentGroups.Piano, //BrightAcousticPiano,
            InstrumentGroups.Piano, //ElectricGrandPiano,
            InstrumentGroups.Piano, //HonkytonkPiano,
            InstrumentGroups.Piano, //ElectricPiano1,
            InstrumentGroups.Piano, //ElectricPiano2,
            InstrumentGroups.Piano, //Harpsichord,
            InstrumentGroups.Piano, //Clavi,
            //Chromatic Percussion
            InstrumentGroups.ChromaticPercussion, //Celesta,
            InstrumentGroups.ChromaticPercussion, //Glockenspiel,
            InstrumentGroups.ChromaticPercussion, //MusicBox,
            InstrumentGroups.ChromaticPercussion, //Vibraphone,
            InstrumentGroups.ChromaticPercussion, //Marimba,
            InstrumentGroups.ChromaticPercussion, //Xylophone,
            InstrumentGroups.ChromaticPercussion, //TubularBells,
            InstrumentGroups.ChromaticPercussion, //Dulcimer,
            //Organ
            InstrumentGroups.Organ, //DrawbarOrgan,
            InstrumentGroups.Organ, //PercussiveOrgan,
            InstrumentGroups.Organ, //RockOrgan,
            InstrumentGroups.Organ, //ChurchOrgan,
            InstrumentGroups.Organ, //ReedOrgan,
            InstrumentGroups.Organ, //Accordion,
            InstrumentGroups.Organ, //Harmonica,
            InstrumentGroups.Organ, //TangoAccordion,
            //Guitar
            InstrumentGroups.Guitar, //AcousticGuitarNylon,
            InstrumentGroups.Guitar, //AcousticGuitarSteel,
            InstrumentGroups.Guitar, //ElectricGuitarJazz,
            InstrumentGroups.Guitar, //ElectricGuitarClean,
            InstrumentGroups.Guitar, //ElectricGuitarMuted,
            InstrumentGroups.Guitar, //OverdrivenGuitar,
            InstrumentGroups.Guitar, //DistortionGuitar,
            InstrumentGroups.Guitar, //GuitarHarmonics,
            //Bass
            InstrumentGroups.Bass, //AcousticBass,
            InstrumentGroups.Bass, //ElectricBassFinger,
            InstrumentGroups.Bass, //ElectricBassPick,
            InstrumentGroups.Bass, //FretlessBass,
            InstrumentGroups.Bass, //SlapBass1,
            InstrumentGroups.Bass, //SlapBass2,
            InstrumentGroups.Bass, //SynthBass1,
            InstrumentGroups.Bass, //SynthBass2,
            //Strings
            InstrumentGroups.Strings, //Violin,
            InstrumentGroups.Strings, //Viola,
            InstrumentGroups.Strings, //Cello,
            InstrumentGroups.Strings, //Contrabass,
            InstrumentGroups.Strings, //TremoloStrings,
            InstrumentGroups.Strings, //PizzicatoStrings,
            InstrumentGroups.Strings, //OrchestralHarp,
            InstrumentGroups.Strings, //Timpani,
            //Ensemble
            InstrumentGroups.Ensemble, //StringEnsemble1,
            InstrumentGroups.Ensemble, //StringEnsemble2,
            InstrumentGroups.Ensemble, //SynthStrings1,
            InstrumentGroups.Ensemble, //SynthStrings2,
            InstrumentGroups.Ensemble, //ChoirAahs,
            InstrumentGroups.Ensemble, //VoiceOohs,
            InstrumentGroups.Ensemble, //SynthVoice,
            InstrumentGroups.Ensemble, //OrchestraHit,
            //Brass
            InstrumentGroups.Brass, //Trumpet,
            InstrumentGroups.Brass, //Trombone,
            InstrumentGroups.Brass, //Tuba,
            InstrumentGroups.Brass, //MutedTrumpet,
            InstrumentGroups.Brass, //FrenchHorn,
            InstrumentGroups.Brass, //BrassSection,
            InstrumentGroups.Brass, //SynthBrass1,
            InstrumentGroups.Brass, //SynthBrass2,
            //Reed
            InstrumentGroups.Reed, //SopranoSax,
            InstrumentGroups.Reed, //AltoSax,
            InstrumentGroups.Reed, //TenorSax,
            InstrumentGroups.Reed, //BaritoneSax,
            InstrumentGroups.Reed, //Oboe,
            InstrumentGroups.Reed, //EnglishHorn,
            InstrumentGroups.Reed, //Bassoon,
            InstrumentGroups.Reed, //Clarinet,
            //Pipe
            InstrumentGroups.Pipe, //Piccolo,
            InstrumentGroups.Pipe, //Flute,
            InstrumentGroups.Pipe, //Recorder,
            InstrumentGroups.Pipe, //PanFlute,
            InstrumentGroups.Pipe, //Blownbottle,
            InstrumentGroups.Pipe, //Shakuhachi,
            InstrumentGroups.Pipe, //Whistle,
            InstrumentGroups.Pipe, //Ocarina,
            //Synth
            InstrumentGroups.Synth, //Lead1Square,
            InstrumentGroups.Synth, //Lead2Sawtooth,
            InstrumentGroups.Synth, //Lead3Calliope,
            InstrumentGroups.Synth, //Lead4Chiff,
            InstrumentGroups.Synth, //Lead5Charang,
            InstrumentGroups.Synth, //Lead6Voice,
            InstrumentGroups.Synth, //Lead7Fifths,
            InstrumentGroups.Synth, //Lead8BassAndLead,
            //SynthPad
            InstrumentGroups.SynthPad, //Pad1NewAge,
            InstrumentGroups.SynthPad, //Pad2Warm,
            InstrumentGroups.SynthPad, //Pad3Polysynth,
            InstrumentGroups.SynthPad, //Pad4Choir,
            InstrumentGroups.SynthPad, //Pad5Bowed,
            InstrumentGroups.SynthPad, //Pad6Metallic,
            InstrumentGroups.SynthPad, //Pad7Halo,
            InstrumentGroups.SynthPad, //Pad8Sweep,
            //Synth Effects
            InstrumentGroups.SynthEffects, //FX1Rain,
            InstrumentGroups.SynthEffects, //FX2Soundtrack,
            InstrumentGroups.SynthEffects, //FX3Crystal,
            InstrumentGroups.SynthEffects, //FX4Atmosphere,
            InstrumentGroups.SynthEffects, //FX5Brightness,
            InstrumentGroups.SynthEffects, //FX6Goblins,
            InstrumentGroups.SynthEffects, //FX7Echoes,
            InstrumentGroups.SynthEffects, //FX8SciFi,
            //Ethnic
            InstrumentGroups.Ethnic, //Sitar,
            InstrumentGroups.Ethnic, //Banjo,
            InstrumentGroups.Ethnic, //Shamisen,
            InstrumentGroups.Ethnic, //Koto,
            InstrumentGroups.Ethnic, //Kalimba,
            InstrumentGroups.Ethnic, //Bagpipe,
            InstrumentGroups.Ethnic, //Fiddle,
            InstrumentGroups.Ethnic, //Shanai,
            //Percussive
            InstrumentGroups.Percussive, //TinkleBell,
            InstrumentGroups.Percussive, //Agogô,
            InstrumentGroups.Percussive, //SteelDrums,
            InstrumentGroups.Percussive, //Woodblock,
            InstrumentGroups.Percussive, //TaikoDrum,
            InstrumentGroups.Percussive, //MelodicTom,
            InstrumentGroups.Percussive, //SynthDrum,
            InstrumentGroups.Percussive, //ReverseCymbal,
            //Sound Effects
            InstrumentGroups.SoundEffects, //GuitarFretNoise,
            InstrumentGroups.SoundEffects, //BreathNoise,
            InstrumentGroups.SoundEffects, //Seashore,
            InstrumentGroups.SoundEffects, //BirdTweet,
            InstrumentGroups.SoundEffects, //TelephoneRing,
            InstrumentGroups.SoundEffects, //Helicopter,
            InstrumentGroups.SoundEffects, //Applause,
            InstrumentGroups.SoundEffects, //Gunshot
        };

    }
}
