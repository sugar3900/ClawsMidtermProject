//Maya ASCII 2013 scene
//Name: LivingRoomTable.ma
//Last modified: Wed, Oct 09, 2013 10:48:36 PM
//Codeset: 1252
requires maya "2013";
currentUnit -l centimeter -a degree -t film;
fileInfo "application" "maya";
fileInfo "product" "Maya 2013";
fileInfo "version" "2013 x64";
fileInfo "cutIdentifier" "201202220241-825136";
fileInfo "osv" "Microsoft Windows 7 Home Premium Edition, 64-bit Windows 7 Service Pack 1 (Build 7601)\n";
fileInfo "license" "student";
createNode transform -n "pCube1";
	setAttr ".rp" -type "double3" 0.19868040084838867 0.76446402072906494 0.53292322158813477 ;
	setAttr ".sp" -type "double3" 0.19868040084838867 0.76446402072906494 0.53292322158813477 ;
createNode mesh -n "pCubeShape1" -p "pCube1";
	setAttr -k off ".v";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr -s 36 ".uvst[0].uvsp[0:35]" -type "float2" 0.64395392 0.028579473
		 0.67927134 0.95948827 0.67927134 0.95948827 0.64395392 0.028579473 0.53389287 0.38900775
		 0.54220808 0.60818303 0.46610719 0.61099243 0.45779198 0.39181709 0.32072878 0.040511847
		 0.35604614 0.97142065 0.35604614 0.97142065 0.32072878 0.040511847 0.31016779 0.013443112
		 0.65243435 0.00080782175 0.64586544 0.022319674 0.31834841 0.034410536 0.35413468
		 0.97768033 0.34756571 0.99919236 0.68983233 0.98655701 0.68165183 0.96558952 0.33173406
		 0.068719327 0.63511682 0.057519436 0.3648833 0.94248056 0.66826606 0.93128073 0.64343822
		 0.030268669 0.3213712 0.042158306 0.35656196 0.96973145 0.67862892 0.95784187 0.31016779
		 0.013443112 0.65243435 0.00080782175 0.34756571 0.99919236 0.68983233 0.98655701
		 0.64210582 0.034631729 0.32303035 0.046410918 0.67696977 0.9535892 0.3578943 0.96536839;
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr -s 36 ".pt[0:35]" -type "float3"  1.4906145 1.2639148 0.53292298 
		-1.0932546 1.2639148 0.53292298 0.50285614 0.17088428 0.53292298 -0.10549609 0.17088428 
		0.53292298 0.50285614 0.17088428 0.53292298 -0.10549609 0.17088428 0.53292298 1.4906145 
		1.2639148 0.53292298 -1.0932546 1.2639148 0.53292298 1.5667232 0.23374856 0.63958043 
		1.5667232 0.23374856 0.42626545 -1.1693634 0.23374856 0.42626554 -1.1693634 0.23374856 
		0.63958049 1.5148813 0.17088428 0.51989019 1.5148813 0.17088428 0.54595578 -1.1175214 
		0.17088428 0.54595578 -1.1175214 0.17088428 0.51989019 1.5233318 0.17088428 0.52590412 
		1.5233318 0.17088428 0.53994185 -1.1259717 0.17088428 0.53994185 -1.1259717 0.17088428 
		0.52590412 1.5667232 0.72359633 0.63958043 1.5667232 0.72359633 0.42626545 -1.1693634 
		0.72359633 0.42626554 -1.1693634 0.72359633 0.63958049 1.4906145 0.72359645 0.63364673 
		1.4906145 0.72359645 0.43219912 -1.0932547 0.72359645 0.43219918 -1.0932547 0.72359645 
		0.63364685 1.4740283 0.11895553 0.53292298 1.4740283 0.11895553 0.53292298 -1.0766684 
		0.11895553 0.53292298 -1.0766684 0.11895553 0.53292298 -0.77865988 0.17088428 0.42680407 
		1.1760199 0.17088428 0.42680395 1.1760199 0.17088428 0.6390419 -0.77865988 0.17088428 
		0.63904202;
	setAttr -s 36 ".vt[0:35]"  -5.36956787 -1.041330457 1.83910847 5.36956882 -1.041330099 1.83911037
		 -1.26422346 1.13545942 0.4330039 1.26422405 1.13545942 0.43300438 -1.26422346 1.13545942 -0.43300486
		 1.26422405 1.13545942 -0.43300438 -5.36956787 -1.041330457 -1.83911085 5.36956882 -1.041330099 -1.83910894
		 -5.68589211 0.72864306 1.94745159 -5.68589211 0.72864306 -1.94745398 5.68589306 0.72864342 -1.94745207
		 5.68589306 0.72864342 1.94745445 -5.35032797 0.98584175 1.83251858 -5.35032797 0.98584175 -1.83252096
		 5.35032845 0.98584199 -1.83251905 5.35032845 0.98584199 1.83252048 -5.4408679 0.85915756 1.86352921
		 -5.4408679 0.85915756 -1.86353111 5.44086838 0.85915804 -1.86352921 5.44086838 0.85915804 1.86353111
		 -5.68589211 0.11080563 1.94745159 -5.68589211 0.11080563 -1.94745398 5.68589306 0.11080599 -1.94745207
		 5.68589306 0.11080599 1.94745445 -5.36956787 0.1048559 1.83910847 -5.36956787 0.1048559 -1.83911085
		 5.36956882 0.10485625 -1.83910894 5.36956882 0.10485625 1.83911037 -5.300632 1.12890959 -1.81549978
		 -5.300632 1.12890959 1.8154974 5.30063248 1.12890983 1.81549931 5.30063248 1.12890983 -1.81549788
		 5.039937019 1.13258338 -1.72620821 -5.039936066 1.13258314 -1.72621012 -5.039936066 1.13258314 1.72620821
		 5.039937019 1.13258338 1.72621012;
	setAttr -s 68 ".ed[0:67]"  0 1 0 2 3 0 4 5 0 6 7 0 0 24 0 1 27 0 2 4 0
		 3 5 0 4 33 0 5 32 0 6 0 0 7 1 0 8 16 0 9 21 0 8 9 1 10 22 0 9 10 1 11 19 0 10 11 1
		 11 8 1 12 29 0 13 17 0 12 13 1 14 18 0 13 14 1 15 30 0 14 15 1 15 12 1 16 12 0 17 9 0
		 16 17 1 18 10 0 17 18 1 19 15 0 18 19 1 19 16 1 20 8 0 21 25 0 20 21 1 22 26 0 21 22 1
		 23 11 0 22 23 1 23 20 1 24 20 0 25 6 0 24 25 1 26 7 0 25 26 1 27 23 0 26 27 1 27 24 1
		 28 13 0 29 34 0 28 29 1 30 35 0 29 30 1 31 14 0 30 31 1 31 28 1 32 31 0 33 28 0 32 33 1
		 34 2 0 33 34 1 35 3 0 34 35 1 35 32 1;
	setAttr -s 34 -ch 136 ".fc[0:33]" -type "polyFaces" 
		f 4 0 5 51 -5
		mu 0 4 0 1 2 3
		f 4 1 7 -3 -7
		mu 0 4 4 5 6 7
		f 4 48 47 -4 -46
		mu 0 4 8 9 10 11
		f 4 3 11 -1 -11
		mu 0 4 11 10 1 0
		f 4 -12 -48 50 -6
		mu 0 4 1 10 9 2
		f 4 10 4 46 45
		mu 0 4 11 0 3 8
		f 4 -15 12 30 29
		mu 0 4 12 13 14 15
		f 4 32 31 -17 -30
		mu 0 4 15 16 17 12
		f 4 -19 -32 34 -18
		mu 0 4 18 17 16 19
		f 4 -20 17 35 -13
		mu 0 4 13 18 19 14
		f 4 64 63 6 8
		mu 0 4 20 21 4 7
		f 4 2 9 62 -9
		mu 0 4 7 6 22 20
		f 4 67 -10 -8 -66
		mu 0 4 23 22 6 5
		f 4 66 65 -2 -64
		mu 0 4 21 23 5 4
		f 4 -31 28 22 21
		mu 0 4 15 14 24 25
		f 4 24 23 -33 -22
		mu 0 4 25 26 16 15
		f 4 -35 -24 26 -34
		mu 0 4 19 16 26 27
		f 4 -36 33 27 -29
		mu 0 4 14 19 27 24
		f 4 -39 36 14 13
		mu 0 4 28 29 13 12
		f 4 16 15 -41 -14
		mu 0 4 12 17 30 28
		f 4 -43 -16 18 -42
		mu 0 4 31 30 17 18
		f 4 -44 41 19 -37
		mu 0 4 29 31 18 13
		f 4 -47 44 38 37
		mu 0 4 8 3 29 28
		f 4 40 39 -49 -38
		mu 0 4 28 30 9 8
		f 4 -51 -40 42 -50
		mu 0 4 2 9 30 31
		f 4 -52 49 43 -45
		mu 0 4 3 2 31 29
		f 4 -23 20 -55 52
		mu 0 4 25 24 32 33
		f 4 -28 25 -57 -21
		mu 0 4 24 27 34 32
		f 4 -27 -58 -59 -26
		mu 0 4 27 26 35 34
		f 4 -60 57 -25 -53
		mu 0 4 33 35 26 25
		f 4 -63 60 59 -62
		mu 0 4 20 22 35 33
		f 4 54 53 -65 61
		mu 0 4 33 32 21 20
		f 4 56 55 -67 -54
		mu 0 4 32 34 23 21
		f 4 58 -61 -68 -56
		mu 0 4 34 35 22 23;
	setAttr ".cd" -type "dataPolyComponent" Index_Data Edge 0 ;
	setAttr ".cvd" -type "dataPolyComponent" Index_Data Vertex 0 ;
	setAttr ".hfd" -type "dataPolyComponent" Index_Data Face 0 ;
createNode materialInfo -n "materialInfo1";
createNode shadingEngine -n "lambert2SG";
	setAttr ".ihi" 0;
	setAttr ".ro" yes;
createNode lambert -n "lambert2";
createNode file -n "file1";
	setAttr ".ftn" -type "string" "C:/Users/kirstensugar/Documents/Game Modding/Unity Projects/Flow Game/Assets/Materials/darkWoodLivingRoomTable.jpg";
createNode place2dTexture -n "place2dTexture1";
createNode lightLinker -s -n "lightLinker1";
	setAttr -s 3 ".lnk";
	setAttr -s 3 ".slnk";
select -ne :time1;
	setAttr ".o" 1;
	setAttr ".unw" 1;
select -ne :renderPartition;
	setAttr -s 3 ".st";
select -ne :initialShadingGroup;
	setAttr ".ro" yes;
select -ne :initialParticleSE;
	setAttr ".ro" yes;
select -ne :defaultShaderList1;
	setAttr -s 3 ".s";
select -ne :defaultTextureList1;
select -ne :postProcessList1;
	setAttr -s 2 ".p";
select -ne :defaultRenderUtilityList1;
select -ne :defaultRenderingList1;
select -ne :renderGlobalsList1;
select -ne :hardwareRenderGlobals;
	setAttr ".ctrs" 256;
	setAttr ".btrs" 512;
select -ne :defaultHardwareRenderGlobals;
	setAttr ".fn" -type "string" "im";
	setAttr ".res" -type "string" "ntsc_4d 646 485 1.333";
connectAttr "lambert2SG.msg" "materialInfo1.sg";
connectAttr "lambert2.msg" "materialInfo1.m";
connectAttr "file1.msg" "materialInfo1.t" -na;
connectAttr "lambert2.oc" "lambert2SG.ss";
connectAttr "pCubeShape1.iog" "lambert2SG.dsm" -na;
connectAttr "file1.oc" "lambert2.c";
connectAttr "place2dTexture1.c" "file1.c";
connectAttr "place2dTexture1.tf" "file1.tf";
connectAttr "place2dTexture1.rf" "file1.rf";
connectAttr "place2dTexture1.mu" "file1.mu";
connectAttr "place2dTexture1.mv" "file1.mv";
connectAttr "place2dTexture1.s" "file1.s";
connectAttr "place2dTexture1.wu" "file1.wu";
connectAttr "place2dTexture1.wv" "file1.wv";
connectAttr "place2dTexture1.re" "file1.re";
connectAttr "place2dTexture1.of" "file1.of";
connectAttr "place2dTexture1.r" "file1.ro";
connectAttr "place2dTexture1.n" "file1.n";
connectAttr "place2dTexture1.vt1" "file1.vt1";
connectAttr "place2dTexture1.vt2" "file1.vt2";
connectAttr "place2dTexture1.vt3" "file1.vt3";
connectAttr "place2dTexture1.vc1" "file1.vc1";
connectAttr "place2dTexture1.o" "file1.uv";
connectAttr "place2dTexture1.ofs" "file1.fs";
relationship "link" ":lightLinker1" ":initialShadingGroup.message" ":defaultLightSet.message";
relationship "link" ":lightLinker1" ":initialParticleSE.message" ":defaultLightSet.message";
relationship "link" ":lightLinker1" "lambert2SG.message" ":defaultLightSet.message";
relationship "shadowLink" ":lightLinker1" ":initialShadingGroup.message" ":defaultLightSet.message";
relationship "shadowLink" ":lightLinker1" ":initialParticleSE.message" ":defaultLightSet.message";
relationship "shadowLink" ":lightLinker1" "lambert2SG.message" ":defaultLightSet.message";
connectAttr "lambert2SG.pa" ":renderPartition.st" -na;
connectAttr "lambert2.msg" ":defaultShaderList1.s" -na;
connectAttr "file1.msg" ":defaultTextureList1.tx" -na;
connectAttr "place2dTexture1.msg" ":defaultRenderUtilityList1.u" -na;
// End of LivingRoomTable.ma
