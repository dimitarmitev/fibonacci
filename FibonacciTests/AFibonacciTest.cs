﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Numerics;

namespace Fibonacci.Tests
{
    /// <summary>
    /// Общ тестов клас за функционалности пресмятащи n-ият член на 
    /// редица на Фибоначи.
    /// </summary>
    public abstract class AFibonacciTest
    {
        /// <summary>
        /// Клас, който ще тестваме
        /// </summary>
        protected static IFibonacciCalculator<ushort> FibonachiCalculator { get; set; }

        [TestMethod]
        public void Test_0()
        {
            var result = FibonachiCalculator.CalculateNth(0);
            Assert.AreEqual(result, new BigInteger(0));
        }

        [TestMethod]
        public void Test_1()
        {
            var result = FibonachiCalculator.CalculateNth(1);
            Assert.AreEqual(result, new BigInteger(1));
        }

        [TestMethod]
        public void Test_2()
        {
            var result = FibonachiCalculator.CalculateNth(2);
            Assert.AreEqual(result, new BigInteger(1));
        }

        [TestMethod]
        public void Test_5()
        {
            var result = FibonachiCalculator.CalculateNth(5);
            Assert.AreEqual(result, new BigInteger(5));
        }

        [TestMethod]
        public void Test_100()
        {
            var result = FibonachiCalculator.CalculateNth(100);
            Assert.AreEqual(result, BigInteger.Parse("354224848179261915075"));
        }

        [TestMethod]
        public void Test_300()
        {
            var result = FibonachiCalculator.CalculateNth(300);
            Assert.AreEqual(result, BigInteger.Parse("222232244629420445529739893461909967206666939096499764990979600"));
        }

        [TestMethod]
        public void Test_UshortMaxValue()
        {
            var result = FibonachiCalculator.CalculateNth(ushort.MaxValue);
            Assert.AreEqual(result, BigInteger.Parse("4523960248625235182227572545439524852637219101241540996484357572169397645441166606997581001845740377981346066857914612399827771864644726197570994889758139482742875281130764389810589772537653473055111889708134503250762886082973555171724033494074906779358076747370767408000804347547785777051914187897655831765658132058258484914846574974023322517786534098357494349603394482014777500144048968717460049415467242667801025223815423274937676661432462561268046024893486054320225515514780983535096202630750560106502119597776367245892785206534959787444510575775211880962881006778074917717594700227547225121274173936201204428475852900254944307515514091270059371986160255481702173356426882493645244287095614581246359900066222654048102353426940128969740477245156506498671273230017077311310435236028131914759138602430423279806112475913873792785975587961590476723592783563229463017237036803656954113121251058968961269473602401131457955151742038425724160182705060376145453473894588874559678094806309215631060621874883119819655585268106408075493191432263283743238528857536397575073976512262970109869396889397754519227185762234283171024709953150152618689469250716737640968327274199116808410133762355295694537586235867734364873260528870945939686743825897145056333151800754495467383917575670259073772548003720090935818185779932047929205199207493744700850690102069473657543109837651339045776592659048044567599588329930221722199419598992229389509942266627103566462529477839875613690412037024360304936715013243325137042084592078924243784300185465037176733240285843966818914833415589093594883187841390778175775389313265197935668777713946574113104701130832759710832800958241029542455430092480221588390760054114207723877277266827035535668679693279856082427467335792794452016064082646879811323059376045692071749198910786709678072419197038166400462268975242159561146174009341876816612320342433144204020733678395287275019254926644491612281779117002806096952058421482490852746112357759762582589641300692476199639867299546116391003226043033707940283059059716312853113062461123152595129845943777095754437211617385791234274292737766242954854749385700192897228476819492860061943359182425910947434981197488937696697842281343538567016683177530637927953722173815216137201485609562755968616381356453173466507927501976065973273899366524521014297981538006040800415929901949059021030780949714999445272725198138201360515860311958345204448200777961168417420876063495170820592956279980193239027160866202455484397347492412706671085781748152593609629997150269810756079212896826762010559265108137693871525129071374248795072465132638150280821444589286220686077185988433371743612517615319747266140513148586055442816932523289681880926359031774090350404701264801557230774840484547335568965610288725316234185381625002387320570007092358762801645987664940117077751858282724443299068610769343193414064145934560039752466428815141042650656134730729740121308738445244655292977811585842377625757178228469313202051264871480455030308285442348828175959360134426561153171897646753352681707874967547627674262341593443920359820656309225675201043986271252101701887658414059968880283725940371207141335491043676764707189204510437858577578225139455738809385296630836908497107050363745786619389696853175072043286605722668132421542694241729637901472340980693277235436788914317889104200566187811006953516996346210097594685365055570160201202247490763973012433580421739689012198895886449438052062665890831067772796483923278001825784890913546427256604243907201252699323427573212800858567881212886061445454806433360237548993860132379762713211355958934681632608671939296921178652067971458138456544493863229319607513606097507988418206777075778184355240148891014551188875435877563502523627223945919945106119844821420391071660205874060679887622723475714545351101365419122391510846649276056615153586224923316981536048908357200917764090457908213016485803993740083689143159195243134428071098865765001980478973809954758585734671475078774526844371084964976394147050916127957381590752884571012489108429253596979503976619668810943459205533344726355815138305256136431940909125626368497454806714832569575277532568148433889503401642175148859569865583433192205415770912020723880060704726364162714115412134178718692966213752021496577364273564098384221155480712435891197244008494160261023262357370321860106094487845777036412178884488762233804511857100842370777728319746224992175225741510590334983945204603188972558806803256796153871055724327992428509498340822882083122522293657019222202002928792518819023039158342843568495621929184377889226001776531334575312288123842910654230036179594387732809741274890717445061145328199063604158216755483567149241273279341522640793391578414178687186991819027758697789180145476867232722597333060911799661369200197689197056773921905953246151104152179509929795478823350980236938129783956394734125068780322298110105948662293645483704769399637890820628719944988381503282092818858325094175807052078384208948038529614061443982031640324333905185880133584599249400508593826433905924972887024409109506860850393095661361510958398822106110804808193435215610521027006847512531385894955256273360048176351024455213644961583312398564733344583222211699837360033247844961402905133819823738418592825713883720536654364000107979695307583608979920437978589531748267793824500801963239833381664622152560434553966431778789699831659157747517927221060246910240225386649375026581584377370659802889136017995078659101912888211265295289913317639294561414020207679610413541268312935211850588422471663200074193901159402224855361377935605887003241212695423166758475897005529035120191209771543146694288855972411728525650565184471543264787182375577102245108515304649327114633486979370133003068359350715365720271826116539100858405149197775140316329948505804033680060766886940424840693851664247628156906380374552675606411515632400866124541318321832055047533335976649105131314323039059073039479069486512631532931205707633931428080929613170766211580808795634180696954650335186730036012159171379246878830219322552441325246203658338079032481908965294037233558380177690095997141364052092494235538190891290276891894898662934734451613473802275368756666830688469438539789570863666978517645807909893390972475966628937596298538215005186747313701522424392941793910215381920634610676224748320317591145160041662594066152784952986204813606144525717037381183736048163827076375914066280366163878091782069549029205553139442079855479162543438809349840663659046048966660355243082797443291834017012208374093548316274044848349318603166027380049046943642068650877234389103057599133341750019887059320482978511652993442030396267725070289396555597953738651494304040771003605700539706338286945017349396666051155410268668502535264167254876295980293193315986522839939601181668638922800751308304754214113596745494948823505590398281284714697634483118704463857093320763368002954556941242722736925838129327829389107700864252725105015606867433429583043306871302549601185994621621242960596584330965235405272940799097268667353257626805946855660315158560493028870334852922549841597077444124243171580255598170689695937905620378290816626074423004023433768111138406011341102577042862027248524271007652174088688311751404185555705359405878493673866148544630327829801083565186415703853245191406545735193356070835550897364560500291839772610944333906831924555014484900870964762768718916161377825103051327886861582621135951007239184098227015334793941152150428465755054611749872409159683468486761029294633146296570976047049668946703516238305600796352974785552070429777525015377168294953794586657527841976382906902887305344241229848798441345074844054658527718732863054226966474427030959248149062383021366472389074994914691475374673582445101188304009341489047552573587928926993666336232338890231988834456211480133910625127517449190205261854314078534624156147735415360462964361679168565263283821555000881689451394275219460052239978322378759106183614589073942255341591403756860641660438589596701650441339783206738236072417812681778543027108013653748946015429791686414099332235833824624344735251655716189272690937386813487048493780704958214046755073417281534005902417287356177749752240212988870750082616863075841385824976421480492051457371850895279537520053955044800068337150625156861972240478451373870404691416604434827383451956517235509927925088153710951172700672428928440867324879833979821814325489994412661307954820090280388643442692769854979201184650384163813400287730804157319815306825220473436747720928776608889930770711365581721494002994470476026211756978135592876074642370718135271059402297076709330411675997476974239919628919292153618037047566525193875335340452469316921754118072336638551336812869693743600313306484188242739839699944227493041017178354142864716190428544238295495711476994003275000217173952655718291085072353931797339126494099833414158737974304265797599202931666055381018477847095252772924170888311582846272346052600769598478265547694445988762167453046210885870976491446033865888352585908088990281883143662123296845294667558810371260778580393293318751264115776616379391631802483786372131462876026101441270286665589057067051834482734106196896301021380940495947790598690960621082143835225046022801305483432268037571322811858311754720900466695826156399153848075402156200469223939806592677386093252123216804424845207469718958636470903199282688239661598498256508967491397228375429459429771228345475903434019570433492478197828454102904178668409744346885720840765192336499977148261964467505384901441143291049777395572727960355882968953017394711522294768033236782406786876424530869771167245249775507559377743248065404546528809992579576803422253846057457284948021008408056559682540867361103322371292276416791174065750834671666791271784932530151472337947831082082061140910496566210602588552323750712309478588168663585713383011424983150591875518924349368918626873937602044327073374398828479935205275834411912502321241965957571838307390894639592238914550344834221007189153087493681335655070189764330012401696628311669852529188436921278669626133068354114940733744497769413214110687442096862720308175585288608549893138784679253123293577549541195282810254148970563851334806709036706588905790906365845041771152697906532817810533568098075351225287057604214046853040011925374505350868803960817306482821698896763418656409461890613720887411754086310579608678730023536672587392899300736382645648825707213884810051280924100709195711337321103306757672430043415543466037135421664231522307496584270340360429227244924918599200563449477998441749156094865122103617981365621632499333529648088832250065774180803982372847495158640504549278201515200215104564028443041163032967812707725018320584970179462462582712498294736475524739146532194109669348717568017713430769711556913761860450453421738040002789935794019796772627823116081229175787397448833948763294585603431775966629133071032875281517647220875189184396712283331801294247590379466329923927414714289575765119391447147802290308518418849733951429426464422909022795386478337463953429889452200167317215334151647820262594137948780508580099231231985361155193703825063744082763710953597547020151949490148139799226396881640389336630835264790677434105409008115841962809764566278953083897017643524597769256096125632033655345189416641734281524686781616119251418265954949228713518181121869344609933404695189615245897865436425053464750249932494565629969470687351991145373878635298756120448861885863553236286764986150703672777643399762566148724185084123050986222114246330507878361845260832928875130916804187190034870433365066203294593621860962669449986114522128353593498378293927166548065398336394766075527979761144779639870835766201083708807993958989029926200527596048336204171419003804184358938743757684512911717196274258865321363896254253270416680122378540045765242254702229199369573485393696590718929917096150119643827152248544027807695196355642690354990980043824677032231872231983074148211554571076499613189200648299623493335292743582318077363221246160613354080207658034982163119091969734063754962744367213282183018918707559139084965877645628897806183907930271885757263856663569876880958659161010042413738131405979994834524429090527736133595620039359147367212005880358420573932867145757020606959515175456159816573383428527834282565629776890920771869955949000694228291541199841783515055675861721039609605842437383544673867849157750956062401785153568237678560857208460711774795859618227788821152789078510755833366756587469022494828015135493665121304252354427655921972442317066207140814164050010399526697483520715988839288503989445264505424917354089824003213840053095983859329307078641610016068407166403332394416080861345119537080610284343584280464240408308737413979828168011660765802788115086326677757936813517969538000507403975527544370745468808206335987835694089383784461112421554542723668657075805533708827784235309611444384262173895082725136759256478939922762391780170984580396605372174819224882180222098687437177553518627078869830720161973060596764184700682510282411882675702026945523318877052952916668242175182497423477221033421578172720221331255051503841276269597313752442020426677587311472493193595908243815192252489481041651897528221145958180153761686035509002152803524703546647707292787029162186033889494951163282047499289297506974088568175728778077737843896302263654813586906790270779876090715036411527757582020591637599969881757324623460045346243585986115528013474433971290550235072881542726107526221358241413351007707911006221650610557651129298005657196852073411069810847466324908242742399862899384944833690167382808810421639299396429937882028247019333466130788352786192839649650667489757790584193535640659703481846028333196079967599262329791178792626769677975367497035929220849441287931365090"));
        }

    }
}
