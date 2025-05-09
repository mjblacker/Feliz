namespace Feliz.Recharts

open Feliz
open Fable.Core
open Fable.Core.JsInterop


[<Erase>]
type Recharts =

    static member inline areaChart(properties: IAreaChartProperty list) =
        ReactLegacy.createElement (import "AreaChart" "recharts" |> unbox<ReactElement>, createObj !!properties)

    static member inline lineChart(properties: ILineChartProperty list) =
        ReactLegacy.createElement (import "LineChart" "recharts" |> unbox<ReactElement>, createObj !!properties)

    static member inline barChart(properties: IBarChartProperty list) =
        ReactLegacy.createElement (import "BarChart" "recharts" |> unbox<ReactElement>, createObj !!properties)

    static member inline pieChart(properties: IPieChartProperty list) =
        ReactLegacy.createElement (import "PieChart" "recharts" |> unbox<ReactElement>, createObj !!properties)

    static member inline radarChart(properties: IRadarChartProperty list) =
        ReactLegacy.createElement (import "RadarChart" "recharts" |> unbox<ReactElement>, createObj !!properties)

    static member inline radialBarChart(properties: IRadialBarChartProperty list) =
        ReactLegacy.createElement (import "RadialBarChart" "recharts" |> unbox<ReactElement>, createObj !!properties)

    static member inline funnelChart(properties: IFunnelChartProperty list) =
        ReactLegacy.createElement (import "FunnelChart" "recharts" |> unbox<ReactElement>, createObj !!properties)

    static member inline composedChart(properties: IComposedChartProperty list) =
        ReactLegacy.createElement (import "ComposedChart" "recharts" |> unbox<ReactElement>, createObj !!properties)

    static member inline scatterChart(properties: IScatterChartProperty list) =
        ReactLegacy.createElement (import "ScatterChart" "recharts" |> unbox<ReactElement>, createObj !!properties)

    static member inline bar(properties: IBarProperty list) =
        ReactLegacy.createElement (import "Bar" "recharts" |> unbox<ReactElement>, createObj !!properties)

    static member inline brush(properties: IBrushProperty list) =
        ReactLegacy.createElement (import "Brush" "recharts" |> unbox<ReactElement>, createObj !!properties)

    static member inline xAxis(properties: IXAxisProperty list) =
        ReactLegacy.createElement (import "XAxis" "recharts" |> unbox<ReactElement>, createObj !!properties)

    static member inline yAxis(properties: IYAxisProperty list) =
        ReactLegacy.createElement (import "YAxis" "recharts" |> unbox<ReactElement>, createObj !!properties)

    static member inline zAxis(properties: IZAxisProperty list) =
        ReactLegacy.createElement (import "ZAxis" "recharts" |> unbox<ReactElement>, createObj !!properties)

    static member inline tooltip(properties: ITooltipProperty list) =
        ReactLegacy.createElement (import "Tooltip" "recharts" |> unbox<ReactElement>, createObj !!properties)

    static member inline legend(properties: ILegendProperty list) =
        ReactLegacy.createElement (import "Legend" "recharts" |> unbox<ReactElement>, createObj !!properties)

    static member inline area(properties: IAreaProperty list) =
        ReactLegacy.createElement (import "Area" "recharts" |> unbox<ReactElement>, createObj !!properties)

    /// Cell can be wrapped by Pie, Bar, or RadialBar to specify attributes of each child. In Pie , for example, we can specify the attributes of each child node through data, but the props of Cell have higher priority
    static member inline cell(properties: ICellProperty list) =
        ReactLegacy.createElement (import "Cell" "recharts" |> unbox<ReactElement>, createObj !!properties)

    static member inline labelList(properties: ILabelListProperty list) =
        ReactLegacy.createElement (import "LabelList" "recharts" |> unbox<ReactElement>, createObj !!properties)

    static member inline label(properties: ILabelProperty list) =
        ReactLegacy.createElement (import "Label" "recharts" |> unbox<ReactElement>, createObj !!properties)

    static member inline sector(properties: ISectorProperty list) =
        ReactLegacy.createElement (import "Sector" "recharts" |> unbox<ReactElement>, createObj !!properties)

    static member inline line(properties: ILineProperty list) =
        ReactLegacy.createElement (import "Line" "recharts" |> unbox<ReactElement>, createObj !!properties)

    static member inline cartesianGrid(properties: ICartesianGridProperty list) =
        ReactLegacy.createElement (import "CartesianGrid" "recharts" |> unbox<ReactElement>, createObj !!properties)

    static member inline cartesianAxis(properties: ICartesianAxisProperty list) =
        ReactLegacy.createElement (import "CartesianAxis" "recharts" |> unbox<ReactElement>, createObj !!properties)

    static member inline responsiveContainer(properties: IResponsiveContainerProperty list) =
        ReactLegacy.createElement (
            import "ResponsiveContainer" "recharts" |> unbox<ReactElement>,
            createObj !!properties
        )

    static member inline referenceLine(properties: IReferenceLineProperty list) =
        ReactLegacy.createElement (import "ReferenceLine" "recharts" |> unbox<ReactElement>, createObj !!properties)

    static member inline referenceArea(properties: IReferenceAreaProperty list) =
        ReactLegacy.createElement (import "ReferenceArea" "recharts" |> unbox<ReactElement>, createObj !!properties)


    static member inline referenceDot(properties: IReferenceDotProperty list) =
        ReactLegacy.createElement (import "ReferenceDot" "recharts" |> unbox<ReactElement>, createObj !!properties)

    static member inline pie(properties: IPieProperty list) =
        ReactLegacy.createElement (import "Pie" "recharts" |> unbox<ReactElement>, createObj !!properties)

    static member inline radar(properties: IRadarProperty list) =
        ReactLegacy.createElement (import "Radar" "recharts" |> unbox<ReactElement>, createObj !!properties)

    static member inline radialBar(properties: IRadialBarProperty list) =
        ReactLegacy.createElement (import "RadialBar" "recharts" |> unbox<ReactElement>, createObj !!properties)

    static member inline scatter(properties: IScatterProperty list) =
        ReactLegacy.createElement (import "Scatter" "recharts" |> unbox<ReactElement>, createObj !!properties)

    static member inline polarAngleAxis(properties: IPolarAngleAxisProperty list) =
        ReactLegacy.createElement (import "PolarAngleAxis" "recharts" |> unbox<ReactElement>, createObj !!properties)

    static member inline polarGrid(properties: IPolarGridProperty list) =
        ReactLegacy.createElement (import "PolarGrid" "recharts" |> unbox<ReactElement>, createObj !!properties)

    static member inline polarRadiusAxis(properties: IPolarRadiusAxisProperty list) =
        ReactLegacy.createElement (import "PolarRadiusAxis" "recharts" |> unbox<ReactElement>, createObj !!properties)

    static member inline funnel(properties: IFunnelProperty list) =
        ReactLegacy.createElement (import "Funnel" "recharts" |> unbox<ReactElement>, createObj !!properties)

    static member inline errorBar(properties: IErrorBarProperty list) =
        ReactLegacy.createElement (import "ErrorBar" "recharts" |> unbox<ReactElement>, createObj !!properties)

    static member inline text(properties: ITextProperty list) =
        ReactLegacy.createElement (import "Text" "recharts" |> unbox<ReactElement>, createObj !!properties)
