import * as React from "react";
import {PictureProfile, ResponsiveImageViewModel, ResponsivePicture} from "epiresponsivepicture-react";

export interface ProjectTeaser {
    name: string;
    image: ResponsiveImageViewModel;
    categories: string[];
    url: string;
}

export class ProjectList extends React.Component<{ profile: PictureProfile, projects: ProjectTeaser[] }, { selectedFilter: string | null }> {
    constructor(props: any) {
        super(props);

        this.state = {
            selectedFilter: null
        }

        this.getFilters = this.getFilters.bind(this);
    }

    render() {
        const projects = this.props.projects;
        const filters = this.getFilters(projects)
        const teasers = this.props.projects
            .filter(x => (!this.state.selectedFilter) || x.categories.indexOf(this.state.selectedFilter) >= 0)
            .map(x => ProjectList.getProjectTeaser(x, this.props.profile));
        return <>
            {filters}
            <div className="teasers">   
                {teasers}
            </div>
        </>
    }

    private static getProjectTeaser(x: ProjectTeaser, profile: PictureProfile) {
        return <div className="teaser">
            <a href={x.url} title={x.name}>
                <div className="teaserImage">
                    <ResponsivePicture model={x.image} profile={profile}/>
                </div>
                <h2>{x.name}</h2>
            </a>
        </div>
    }

    private getFilters(projects: ProjectTeaser[]) {
        const categories = projects.map(x => x.categories)
            .reduce((x, y) => x.concat(y), []) // flatten
            .filter((value, index, self) => self.indexOf(value) === index); // distinct
        const filters = categories.map(x => <button className={x === this.state.selectedFilter ? "active" : ""} onClick={() => this.setState({selectedFilter: x})}>{x}</button>)

        return <div className="filters">{filters}</div>
    }
}